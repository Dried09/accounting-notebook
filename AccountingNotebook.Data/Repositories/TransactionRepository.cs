using AccountingNotebook.Common;
using AccountingNotebook.Data.Entities;
using AccountingNotebook.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AccountingNotebook.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public IEnumerable<TransactionEntity> GetAllTransactions()
        {
            return FakeDatabase.Transactions;
        }

        public TransactionEntity GetTransaction(Guid id)
        {
            return FakeDatabase.Transactions.FirstOrDefault(e => e.Id == id);
        }

        public void DoTransaction(TransactionType type, decimal amount)
        {
            FakeDatabase.Transactions.Add(
                new TransactionEntity()
                {
                    Id = Guid.NewGuid(),
                    Type = type,
                    Amount = amount,
                    EffectiveDate = DateTime.UtcNow
                });
        }
    }
}
