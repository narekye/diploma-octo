using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OCTO.Common.Mapper;

namespace OCTO.Common
{
    public static partial class Bootstrap
    {
        public static IServiceCollection ConfigureOCTOMapper(this IServiceCollection services)
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfileConfiguration()));
            services.AddSingleton(o => configuration.CreateMapper());
            return services;
        }
    }
}
