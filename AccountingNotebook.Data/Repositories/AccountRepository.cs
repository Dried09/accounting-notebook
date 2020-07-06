using AccountingNotebook.Data.Entities;
using AccountingNotebook.Data.Interfaces;

namespace AccountingNotebook.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountEntity GetAccountBalance()
        {
            return new AccountEntity() 
            { 
                AccountBalance = FakeDatabase.Account.AccountBalance
            };
        }
    }
}
