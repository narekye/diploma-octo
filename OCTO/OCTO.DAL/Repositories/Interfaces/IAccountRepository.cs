using OCTO.DAL.Core;
using OCTO.DAL.Models;

namespace OCTO.DAL.Repositories.Interfaces
{
    public interface IAccountRepository : IRepositoryBase<Account>, IDatabaseTransaction
    {
    }
}
