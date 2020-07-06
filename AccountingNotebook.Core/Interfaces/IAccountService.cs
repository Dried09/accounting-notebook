using AccountingNotebook.Core.Models;

namespace AccountingNotebook.Core.Interfaces
{
    public interface IAccountService
    {
        AccountModel GetAccountBalance();
    }
}
