using AccountingNotebook.Common;
using AccountingNotebook.Data.Entities;
using System;
using System.Collections.Generic;

namespace AccountingNotebook.Data.Interfaces
{
    public interface ITransactionRepository
    {
        IEnumerable<TransactionEntity> GetAllTransactions();
        TransactionEntity GetTransaction(Guid id);
        void DoTransaction(TransactionType type, decimal amount);
    }
}
