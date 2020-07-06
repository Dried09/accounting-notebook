using AccountingNotebook.Common;
using AccountingNotebook.Core.Interfaces;
using AccountingNotebook.Core.Models;
using AccountingNotebook.Data.Entities;
using AccountingNotebook.Data.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AccountingNotebook.Core.Services
{
    public class TransactionService : ITransactionService
    {
        private ITransactionRepository TransactionRepository { get; set; }
        private IAccountRepository AccountRepository { get; set; }
        private IMapper Mapper { get; set; }

        public TransactionService(ITransactionRepository transactionRepository, IAccountRepository accountRepository, IMapper mapper)
        {
            TransactionRepository = transactionRepository;
            AccountRepository = accountRepository;
            Mapper = mapper;
        }

        public IEnumerable<TransactionModel> GetAllTransactions()
        {
            return Mapper.Map<IEnumerable<TransactionEntity>, List<TransactionModel>>(TransactionRepository.GetAllTransactions());
        }

        public TransactionModel GetTransaction(Guid id)
        {
            return Mapper.Map<TransactionEntity, TransactionModel>(TransactionRepository.GetTransaction(id));
        }

        public bool DoTransaction(TransactionType type, decimal amount)
        {
            if (type == TransactionType.Credit
                && (AccountRepository.GetAccountBalance().AccountBalance - amount) < 0)
            {
                return false;
            }

            TransactionRepository.DoTransaction(type, amount);
            return true;
        }
    }
}
