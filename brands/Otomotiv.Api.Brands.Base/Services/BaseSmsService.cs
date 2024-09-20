using Otomotiv.Api.Common.IOC;
using System.Security.Cryptography;

namespace Otomotiv.Api.Brands.Base.Services
{
    public abstract class BaseSmsService : IBaseSmsService
    {
        public virtual Task<string> GenerateSmsCode()
        {
            var randomNumberBuffer = new byte[10];
            new RNGCryptoServiceProvider().GetBytes(randomNumberBuffer);
            var result = new Random(BitConverter.ToInt32(randomNumberBuffer, 0)).Next(1234, 9876);
            return Task.FromResult(result.ToString());
        }
    }
}
