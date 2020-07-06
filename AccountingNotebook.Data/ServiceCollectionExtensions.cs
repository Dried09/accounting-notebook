using AccountingNotebook.Data.Interfaces;
using AccountingNotebook.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AccountingNotebook.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransactionRepository, TransactionRepository>();
        }
    }
}
