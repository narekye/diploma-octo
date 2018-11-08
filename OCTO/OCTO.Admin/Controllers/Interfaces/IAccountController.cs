using Microsoft.AspNetCore.Mvc;
using OCTO.BLL.Models;
using OCTO.BLL.Models.Filters;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers.Interfaces
{
    public interface IAccountController
    {
        Task<ActionResult> GetAccounts();
        Task<ActionResult> GetAccountsByFilterAsync(AccountFilterModel accountFilter);
        Task<ActionResult> CreateAccountAsync(AccountModel account);
        //Task<ActionResult> GetAccountByIdAsync(int accountId);
    }
}
