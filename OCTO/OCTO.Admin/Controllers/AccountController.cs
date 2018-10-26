using Microsoft.AspNetCore.Mvc;
using OCTO.Admin.Controllers.Core;
using OCTO.BLL.Interfaces.Account;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers
{
    public class AccountController : ApiControllerBase
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
    }
}
