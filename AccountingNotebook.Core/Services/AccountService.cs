using AccountingNotebook.Core.Interfaces;
using AccountingNotebook.Core.Models;
using AccountingNotebook.Data.Interfaces;
using AutoMapper;
using AccountingNotebook.Data.Entities;

namespace AccountingNotebook.Core.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository AccountRepository { get; set; }
        private IMapper Mapper { get; set; }

        public AccountService(IAccountRepository accountRepository, IMapper mapper)
        {
            AccountRepository = accountRepository;
            Mapper = mapper;
        }

        public AccountModel GetAccountBalance()
        {
            return Mapper.Map<AccountEntity, AccountModel>(AccountRepository.GetAccountBalance());
        }
    }
}
