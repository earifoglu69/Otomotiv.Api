using Otomotiv.Api.Brands.Base.Services;
using Otomotiv.Api.Common.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Otomotiv.Api.Brands.Seat.Services
{
    public class SeatSmsService : BaseSmsService, IScopedService
    {

        public SeatSmsService()
        {
        }

        public override async Task<string> GenerateSmsCode()
        {
            var randomNumberBuffer = new byte[10];
            new RNGCryptoServiceProvider().GetBytes(randomNumberBuffer);
            var result = new Random(BitConverter.ToInt32(randomNumberBuffer, 0)).Next(123456, 987654);
            return $"{result.ToString()}";
        }
    }
}
