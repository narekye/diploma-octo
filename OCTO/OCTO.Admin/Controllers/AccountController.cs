using Microsoft.AspNetCore.Mvc;
using OCTO.BLL.Interfaces.Account;
using OCTO.BLL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCTO.Admin.Controllers
{
    [ApiController, Route("api/[controller]/[action]"), Produces("application/json")]
    public class AccountController : ControllerBase
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountModel>>> GetAccounts()
        {
            var items = await _accountService.GetAccountsAsync();
            return Ok(items);
        }
    }
}
