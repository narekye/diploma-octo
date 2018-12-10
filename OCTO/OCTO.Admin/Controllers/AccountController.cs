using Microsoft.AspNetCore.Mvc;
using OCTO.Admin.Controllers.Core;
using OCTO.Admin.Controllers.Interfaces;
using OCTO.BLL.Interfaces.Account;
using OCTO.BLL.Models;
using OCTO.BLL.Models.Filters;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers
{
    public class AccountController : ApiControllerBase, IAccountController
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAccounts()
        {
            var items = await _accountService.GetAccountsAsync();
            return CreateResponse(items);
        }

        [HttpPost]
        public async Task<ActionResult> GetAccountsByFilterAsync(AccountFilterModel accountFilter)
        {
            var accounts = await _accountService.GetAccountsAsync(accountFilter);
            return CreateResponse(accounts);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAccountAsync(AccountModel account)
        {
            var newAccount = await _accountService.CreateAccountAsync(account);
            return CreateResponse(newAccount);
        }

        [HttpGet]
        public async Task<ActionResult> GetAccountByIdAsync([FromQuery] int accountId)
        {
            var account = await _accountService.GetAccountByIdAsync(accountId);
            return CreateResponse(account);
        }
    }
}
