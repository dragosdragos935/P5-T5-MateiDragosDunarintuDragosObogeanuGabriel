using Microsoft.AspNetCore.Mvc;

namespace aplicatie.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("user/{userId}/accounts")]
        public IActionResult GetUserAccounts(int userId)
        {
            var accounts = _accountService.GetAccountsByUserId(userId);
            return Ok(accounts);
        }

        [HttpGet("{accountId}/balance")]
        public IActionResult GetAccountBalance(int accountId)
        {
            var balance = _accountService.GetAccountBalance(accountId);
            return Ok(balance);
        }
    }

}
