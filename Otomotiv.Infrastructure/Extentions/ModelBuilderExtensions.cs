using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otomotiv.Infrastructure.Models;

namespace Otomotiv.Infrastructure.Extentions
{

    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrandEntity>().HasData(
                new BrandEntity { Id = 1, Name = "VolksWagenTicari", Code ="VW" },
                new BrandEntity { Id = 2, Name = "VolksWagen", Code ="VW" },
                new BrandEntity { Id = 3, Name = "Turkuaz", Code ="VW" },
                new BrandEntity { Id = 4, Name = "Skoda", Code ="VW" },
                new BrandEntity { Id = 5, Name = "Seat", Code ="VW" },
                new BrandEntity { Id = 6, Name = "Porsche", Code ="VW" },
                new BrandEntity { Id = 7, Name = "Audi", Code ="VW" },
                new BrandEntity { Id = 8, Name = "Scania", Code ="VW" },
                new BrandEntity { Id = 9, Name = "Cupra", Code ="VW" },
                new BrandEntity { Id = 10, Name = "ScaniaNew", Code ="VW" },
                new BrandEntity { Id = 11, Name = "DogusOtomotivDaily", Code ="VW" },
                new BrandEntity { Id = 12, Name = "AutomotiveAccountOperationsUser", Code ="VW" }
            );

            modelBuilder.Entity<PlatformEntity>().HasData(
                new PlatformEntity { Id = 1, Name = "VolksWagenTicari" },
                new PlatformEntity { Id = 2, Name = "VolksWagen" },
                new PlatformEntity { Id = 3, Name = "Turkuaz" },
                new PlatformEntity { Id = 4, Name = "Skoda" },
                new PlatformEntity { Id = 5, Name = "Seat" },
                new PlatformEntity { Id = 6, Name = "Porsche" },
                new PlatformEntity { Id = 7, Name = "Audi" },
                new PlatformEntity { Id = 8, Name = "Scania" },
                new PlatformEntity { Id = 9, Name = "Cupra" },
                new PlatformEntity { Id = 10, Name = "ScaniaNew" },
                new PlatformEntity { Id = 11, Name = "DogusOtomotivDaily" },
                new PlatformEntity { Id = 12, Name = "AutomotiveAccountOperationsUser" }
            );

            modelBuilder.Entity<ChannelEntity>().HasData(
                new ChannelEntity { Id = 1, Name = "Web" },
                new ChannelEntity { Id = 2, Name = "Mobil" }
            );


        }
    }
}
