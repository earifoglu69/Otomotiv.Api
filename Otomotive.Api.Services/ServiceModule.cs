using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using System.Text;
using Otomotiv.Infrastructure;
using Otomotiv.Api.Common.IOC;
using Otomotiv.Api.Brands.Audi;
using Otomotiv.Api.Brands.Base;
using Otomotiv.Api.Brands.VolksWagen;
using Otomotiv.External.Turkuaz;
using Otomotiv.Api.Brands.Seat;


namespace Otomotiv.Application
{
    public static class ServiceModule
    {
        public static void Configure(IServiceCollection services, ConfigurationManager configuration)
        {
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            services.UseIocLoader();

            InfrastructureModule.Configure(services, configuration);
            BrandBaseModule.Configure(services, configuration);
            BrandAudiModule.Configure(services, configuration);
            BrandVolksWagenModule.Configure(services, configuration);
            SeatModule.Configure(services, configuration);
            TurkuazModule.Configure(services, configuration);
            serviceProvider = services.BuildServiceProvider();
        }
    }
}
