using System.Threading.Tasks;

namespace OCTO.BLL.Interfaces
{
    public interface IServiceBase
    {
        Task<int> SaveChangesAsync(bool commit = false);
    }
}
