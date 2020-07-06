using AccountingNotebook.Common;

namespace AccountingNotebook.Data.Entities
{
    public class TransactionEntity : BaseEntity
    {
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
    }
}
