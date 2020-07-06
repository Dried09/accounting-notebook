using AccountingNotebook.Data.Entities;

namespace AccountingNotebook.Data.Interfaces
{
    public interface IAccountRepository
    {
        AccountEntity GetAccountBalance();
    }
}
