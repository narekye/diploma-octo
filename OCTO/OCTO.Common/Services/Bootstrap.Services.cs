using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OCTO.BLL.Account;
using OCTO.BLL.Contact;
using OCTO.BLL.Interfaces.Account;
using OCTO.BLL.Interfaces.Contact;
using OCTO.BLL.Interfaces.Salutation;
using OCTO.BLL.Salutation;
using OCTO.DAL.Models;
using OCTO.DAL.Repositories;
using OCTO.DAL.Repositories.Interfaces;

namespace OCTO.Common
{
    public static partial class Bootstrap
    {
        public static IServiceCollection ConfigureOCTODependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<OctoContext>(o => o.UseSqlServer(connectionString, providerOptions => providerOptions.CommandTimeout(60)), ServiceLifetime.Transient);

            services.AddTransient<ISalutationRepository, SalutationRepository>();
            services.AddTransient<ISalutationService, SalutationService>();

            services.AddTransient<ICountryRepository, CountryRepository>();

            services.AddTransient<IContactRepository, ContactRepository>();
            services.AddTransient<IContactService, ContactService>();

            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IAccountService, AccountService>();

            return services;
        }
    }
}
