using AccountingNotebook.Common;

namespace AccountingNotebook.Core.Models
{
    public class TransactionModel : BaseModel
    {
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
    }
}
