using Microsoft.EntityFrameworkCore;
using Otomotiv.Infrastructure.Extentions;
using Otomotiv.Infrastructure.Models;
namespace Otomotiv.Infrastructure.Context
{
    public class OtomotivDbContext : DbContext
    {
        public OtomotivDbContext(DbContextOptions<OtomotivDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<BrandEntity> Brands { get; set; } = null!;
        public DbSet<ChannelEntity> Channels { get; set; } = null!;
        public DbSet<PlatformEntity> Platforms { get; set; } = null!;
        public DbSet<BrandSettingEntity> BrandSettingEntities { get; set; } = null!;
    }
}
