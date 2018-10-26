using OCTO.BLL.Interfaces.Core;
using OCTO.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.BLL.Interfaces.Account
{
    public interface IAccountService : IServiceBase
    {
        Task<IEnumerable<AccountModel>> GetAccountsAsync();
    }
}
