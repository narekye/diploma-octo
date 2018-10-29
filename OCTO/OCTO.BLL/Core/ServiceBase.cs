using OCTO.BLL.Interfaces.Core;
using OCTO.DAL.Core;
using System;
using System.Text;
using System.Threading.Tasks;

namespace OCTO.BLL.Core
{
    public class ServiceBase : IServiceBase
    {
        public bool IsChild { get; }

        public bool IsCommitingChanges { get; set; }

        public IServiceBase Parent { get; set; }

        IDatabaseTransaction DatabaseTransaction { get; set; }

        public bool IsSavingChanges { get; set; }

        private ServiceBase()
        {
            IsCommitingChanges = true;
            IsSavingChanges = true;
        }

        public ServiceBase(IDatabaseTransaction databaseTransaction) : this()
        {
            DatabaseTransaction = databaseTransaction;
        }

        public ServiceBase(IDatabaseTransaction databaseTransaction, ServiceBase parent) : this(databaseTransaction)
        {
            DatabaseTransaction = databaseTransaction;

            if (parent != null)
            {
                DatabaseTransaction = parent.DatabaseTransaction;
                IsCommitingChanges = false; // When BL is child
                IsChild = true;
            }
        }

        public void EnsureTransaction()
        {
            if (DatabaseTransaction != null)
                DatabaseTransaction.EnsureTransactionAsync();
        }

        public void RollbackTransaction()
        {
            if (DatabaseTransaction != null)
                DatabaseTransaction.RollbackTransaction();
        }

        public Task<int> SaveChangesAsync(bool commit = false)
        {
            if (!IsSavingChanges) return Task.FromResult(-1);

            commit = commit && IsCommitingChanges;

            if (IsChild && IsCommitingChanges)
                throw CreateException("NOT ALLOWED");

            return DatabaseTransaction.SaveChangesAsync(commit);
        }

        public void Dispose()
        {
            DatabaseTransaction.Dispose();
        }

        protected Exception CreateException(params string[] args)
        {
            var builder = new StringBuilder();
            foreach (var arg in args)
                builder.Append($"{arg}{Environment.NewLine}");

            return new Exception(builder.ToString());
        }
    }
}
