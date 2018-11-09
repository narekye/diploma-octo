using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OCTO.DAL.Core
{
    public abstract class RepositoryBase<TEntity, TDbContext> : DatabaseTransaction<TDbContext>, IRepositoryBase<TEntity>
        where TDbContext : DbContext
        where TEntity : class
    {
        public RepositoryBase(TDbContext dbContext) : base(dbContext) { }

        public void Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentException(nameof(entity));

            _dbContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null || entities.Any(e => e == null))
                throw new ArgumentException(nameof(entities));

            _dbContext.Set<TEntity>().AddRange(entities);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            var query = _dbContext.Set<TEntity>();
            return await (predicate == null ? query.AnyAsync() : query.AnyAsync(predicate));
        }

        public async void RemoveById(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
                Remove(entity);
        }

        public void Remove(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
        }

        public void Edit(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            var query = _dbContext.Set<TEntity>();
            return await (predicate == null ? query.FirstOrDefaultAsync() : query.FirstOrDefaultAsync(predicate));
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = _dbContext.Set<TEntity>();
            return await (filter == null ? query.ToListAsync() : query.Where(filter).ToListAsync());
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<TEntity>().FindAsync(id);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbContext.Set<TEntity>().RemoveRange(entities);
        }

        public virtual async Task<IEnumerable<TEntity>> GetByFilterAsync(IFilter<TEntity> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            var entities = _dbContext.Set<TEntity>().AsQueryable();
            entities = ApplyIncludes(entities, includes);
            return await filter.Apply(entities);
        }

        public virtual IQueryable<TEntity> ApplyIncludes(IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includes)
        {
            query = includes.Aggregate(query, (current, navigationProperty) => current.Include(navigationProperty));
            return query;
        }
    }
}
