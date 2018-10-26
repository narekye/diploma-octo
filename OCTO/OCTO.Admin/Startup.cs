using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using OCTO.Common;

namespace OCTO.Admin
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            services.ConfigureOCTOMapper();
            services.ConfigureOCTODependencies(builder.GetConnectionString("DefaultConnection"));

            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseWelcomePage("/");
            app.UseMvc();
        }
    }
}
