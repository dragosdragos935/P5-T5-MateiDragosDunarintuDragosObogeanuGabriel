using aplicatie.Models;
using Microsoft.AspNetCore.Mvc;

namespace aplicatie.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("transfer")]
        public IActionResult Transfer([FromBody] Transaction model)
        {
            _transactionService.MakeTransaction(model.SourceAccountId, model.DestinationAccountId, model.Amount);
            return Ok("Transaction successful!");
        }

        [HttpGet("account/{accountId}/transactions")]
        public IActionResult GetAccountTransactions(int accountId)
        {
            var transactions = _transactionService.GetTransactionsByAccountId(accountId);
            return Ok(transactions);
        }
    }

}
