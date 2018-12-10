using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
// using OCTO.DAL.Entities;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCTO.DAL.Core
{
    public class DatabaseTransaction<TDbContext> : IDatabaseTransaction where TDbContext : DbContext
    {
        protected readonly TDbContext _dbContext;

        private IDbContextTransaction Transaction { get; set; }

        public DatabaseTransaction(TDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentException(nameof(dbContext));
        }

        public DatabaseTransaction(string connectionString)
        {
            _dbContext = _dbContext ?? (_dbContext = (TDbContext)Activator.CreateInstance(typeof(TDbContext), connectionString));
        }

        public async Task BeginTransactionAsync()
        {
            Transaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public void BeginTransaction()
        {
            Transaction = _dbContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (Transaction != null)
                Transaction.Commit();
            Dispose();
        }

        public void Dispose()
        {
            Transaction?.Dispose();
            Transaction = null;
        }

        public async Task EnsureTransactionAsync()
        {
            if (Transaction == null)
                await BeginTransactionAsync();
        }

        public void EnsureTransaction()
        {
            if (Transaction == null)
                BeginTransaction();
        }

        public void RollbackTransaction()
        {
            if (Transaction != null)
                Transaction.Rollback();

            _dbContext.ChangeTracker.DetectChanges();

            if (!_dbContext.ChangeTracker.HasChanges())
                return;

            var entries = _dbContext.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in entries)
            {
                var entity = entry.Entity;

                if (entity == null)
                    continue;

                switch (entry.State)
                {
                    case EntityState.Added:
                        var set = _dbContext.Remove(entity);
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        break;
                    case EntityState.Modified:
                        entry.Reload();
                        break;
                }
            }
        }

        public async Task<int> SaveChangesAsync(bool commit = true)
        {
            int result = -1;

            try
            {
                if (Transaction == null)
                    throw CreateException($"Value cannot be null {nameof(Transaction)}");

                result = await _dbContext.SaveChangesAsync();
                if (commit)
                    CommitTransaction();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                RollbackTransaction();
                var entry = ex.Entries.FirstOrDefault().Entity;
                string entryInfo = string.Empty;

                //if (entry is IEntity iEntity)
                //    entryInfo = BuildInfo(entry.GetType(), iEntity.Id);

                throw CreateException(nameof(DbUpdateConcurrencyException), entryInfo);
            }
            catch (DbUpdateException ex)
            {
                RollbackTransaction();
                var entry = ex.Entries.FirstOrDefault()?.Entity;
                string entryInfo = string.Empty;

                //if (entry is IEntity iEntity)
                //    entryInfo = BuildInfo(entry.GetType(), iEntity.Id);

                throw CreateException(nameof(DbUpdateException), entryInfo, GetMessageFromInnerException(ex));
            }
            catch (Exception ex)
            {
                RollbackTransaction();
                throw ex;
            }

            return result;
        }

        Exception CreateException(params string[] args)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var arg in args)
                builder.Append($"{arg}{Environment.NewLine}");

            return new Exception(builder.ToString());
        }

        string BuildInfo(Type type, int id) => string.Format("Type: {0}, Id: {1}", type.Name, id);

        string GetMessageFromInnerException(Exception ex)
        {
            while (ex != null)
            {
                if (ex.InnerException == null)
                    return ex.Message;
                ex = ex.InnerException;
            }
            return string.Empty;
        }
    }
}
