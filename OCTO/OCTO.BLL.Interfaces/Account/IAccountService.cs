using OCTO.BLL.Interfaces.Core;
using OCTO.BLL.Models;
using OCTO.BLL.Models.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Interfaces.Account
{
    public interface IAccountService : IServiceBase
    {
        Task<IEnumerable<AccountModel>> GetAccountsAsync();
        Task<IEnumerable<AccountModel>> GetAccountsAsync(AccountFilterModel accountFilterModel);
        Task<AccountModel> GetAccountByIdAsync(int accountId);
    }
}
