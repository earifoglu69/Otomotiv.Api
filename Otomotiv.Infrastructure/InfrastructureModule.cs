using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Infrastructure.Context;
using Otomotiv.Infrastructure.Respositories;
using Otomotiv.Infrastructure.UnitOfWork;

namespace Otomotiv.Infrastructure
{
    public static class InfrastructureModule
    {
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OtomotivDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("OtomotivConnection")));

            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RepositoryAsync<>));
            services.AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>();
        }
    }
}
