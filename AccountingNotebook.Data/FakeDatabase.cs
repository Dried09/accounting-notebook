using AccountingNotebook.Common;
using AccountingNotebook.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AccountingNotebook.Data
{
    static class FakeDatabase
    {
        public static AccountEntity Account
        {
            get => new AccountEntity() { AccountBalance = Transactions.Sum(e => e.Amount * ResolveAmountSign(e.Type)) };
        }

        public static ICollection<TransactionEntity> Transactions { get; set; } = new List<TransactionEntity>();

        private static int ResolveAmountSign(TransactionType type)
        {
            return type == TransactionType.Debit ? 1 : -1;
        }
    }
}
