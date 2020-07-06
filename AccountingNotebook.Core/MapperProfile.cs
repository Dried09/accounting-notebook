using AccountingNotebook.Core.Models;
using AccountingNotebook.Data.Entities;
using AutoMapper;

namespace AccountingNotebook.Core
{
    public class CoreMapProfile : Profile
    {
        public CoreMapProfile()
        {
            CreateMap<AccountEntity, AccountModel>()
                .ReverseMap();
            CreateMap<TransactionEntity, TransactionModel>()
                .ReverseMap();
        }
    }
}
