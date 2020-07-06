using AccountingNotebook.Core.Interfaces;
using AccountingNotebook.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AccountingNotebook.Core
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransactionService, TransactionService>();
        }
    }
}
