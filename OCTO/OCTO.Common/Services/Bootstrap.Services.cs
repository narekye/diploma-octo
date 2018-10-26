using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OCTO.BLL.Account;
using OCTO.BLL.Interfaces.Account;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories;
using OCTO.DAL.Repositories.Interfaces;

namespace OCTO.Common
{
    public static partial class Bootstrap
    {
        public static IServiceCollection ConfigureOCTODependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OctoContext>((o) =>
            {
                o.UseSqlServer(connectionString, providerOptions => providerOptions.CommandTimeout(60));
            }, ServiceLifetime.Singleton);

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ISalutationRepository, SalutationRepository>();
            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddTransient<IAccountService, AccountService>();

            return services;
        }
    }
}
