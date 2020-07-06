using AccountingNotebook.Common;
using AccountingNotebook.Core.Models;
using System;
using System.Collections.Generic;

namespace AccountingNotebook.Core.Interfaces
{
    public interface ITransactionService
    {
        IEnumerable<TransactionModel> GetAllTransactions();
        TransactionModel GetTransaction(Guid id);
        bool DoTransaction(TransactionType type, decimal amount);
    }
}
