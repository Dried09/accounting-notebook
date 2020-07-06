using AccountingNotebook.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AccountingNotebook.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAccountService AccountService { get; set; }

        public AccountController(IAccountService accountService)
        {
            AccountService = accountService;
        }

        [HttpGet]
        public IActionResult GetAccountBalance()
        {
            var result = AccountService.GetAccountBalance();

            return Ok(result);
        }
    }
}
