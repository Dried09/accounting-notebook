using AccountingNotebook.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AccountingNotebook.Api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class HistoryController : Controller
    {
        private ITransactionService TransactionService { get; set; }

        public HistoryController(ITransactionService transactionService)
        {
            TransactionService = transactionService;
        }

        [Route("client")]
        public IActionResult Index()
        {
            var result = TransactionService.GetAllTransactions().ToList();
            return View(result);
        }
    }
}
