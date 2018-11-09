using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OCTO.DAL.Core
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Edit(TEntity entity);
        void RemoveById(int entity);
        void Remove(TEntity entity);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate = null);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate = null);
        Task<TEntity> GetByIdAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null);
        Task<IEnumerable<TEntity>> GetByFilterAsync(IFilter<TEntity> filter, params Expression<Func<TEntity, object>>[] includes);
    }
}
