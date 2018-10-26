using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCTO.DAL.Core
{
    public interface IFilter<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> Apply(IQueryable<TEntity> query);
    }
}
