using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Infrastructure.Context;

namespace Otomotiv.Application.Extentions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();
            using OtomotivDbContext context =scope.ServiceProvider.GetRequiredService<OtomotivDbContext>();
            context.Database.Migrate();
        }
    }
}
