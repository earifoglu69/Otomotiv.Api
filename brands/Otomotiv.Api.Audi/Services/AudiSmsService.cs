using Otomotiv.Api.Brands.Base.Services;
using Otomotiv.Api.Common.IOC;
using Otomotiv.External.Turkuaz.Services;
using System.Security.Cryptography;

namespace Otomotiv.Api.Brands.Audi.Services
{
    public class AudiSmsService : BaseSmsService , IScopedService
    {
        private readonly IVehicleService _vehicleService;

        public AudiSmsService(IVehicleService vehicleService)
        {
            _vehicleService=vehicleService;
        }

        public override async Task<string> GenerateSmsCode()
        {
            var turkuazResponse = await _vehicleService.GetVehiclesInfoAsync();
            var randomNumberBuffer = new byte[10];
            new RNGCryptoServiceProvider().GetBytes(randomNumberBuffer);
            var result = new Random(BitConverter.ToInt32(randomNumberBuffer, 0)).Next(123456, 987654);
            return $"{turkuazResponse}/{result.ToString()}";
        }
    }
}
