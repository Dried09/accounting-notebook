using System;
using AccountingNotebook.Common;
using AccountingNotebook.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AccountingNotebook.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ITransactionService TransactionService { get; set; }

        public TransactionController(ITransactionService transactionService)
        {
            TransactionService = transactionService;
        }

        [HttpGet]
        public IActionResult GetTransactions()
        {
            var result = TransactionService.GetAllTransactions();
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetTransaction(Guid id)
        {
            var result = TransactionService.GetTransaction(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult DoTransaction(TransactionType type, decimal amount)
        {
            var result = TransactionService.DoTransaction(type, amount);

            if (!result)
            {
                return StatusCode(422, "Unprocessable Entity. Unable to complete transaction, insufficient funds.");
            }

            return Ok();
        }
    }
}
