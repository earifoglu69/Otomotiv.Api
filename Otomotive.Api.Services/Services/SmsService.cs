using Microsoft.Extensions.DependencyInjection;
using Otomotiv.Api.Brands.Audi.Services;
using Otomotiv.Api.Brands.Base.Services;
using Otomotiv.Api.Brands.Seat.Services;
using Otomotiv.Api.Common.IOC;
using Otomotiv.Infrastructure.Models;
using Otomotiv.Infrastructure.UnitOfWork;

namespace Otomotiv.Application.Services
{
    public class SmsService : ISmsService, IScopedService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceProvider _serviceProvider;

        public SmsService(IUnitOfWork unitOfWork, IServiceProvider serviceProvider)
        {
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
        }

        public async Task<string> AudiExtraMethod()
        {
            var service = _serviceProvider.GetRequiredService<IAudiSmsService>();
            return await service.ExtraAudiSmsMethod();
        }

        public async Task<string> GenerateCustomerSmsCode(int brandId)
        {
            var brandEntity = await _unitOfWork.GetRepository<BrandEntity>().GetByIdAsync(brandId);
            if (brandEntity == null)
            {
                throw new InvalidOperationException($"Brand with ID {brandId} not found.");
            }

            var services = _serviceProvider.GetServices<IBaseSmsService>();
            if (services == null || !services.Any())
            {
                throw new InvalidOperationException($"Service type for brand {brandEntity.Name} not found.");
            }
            var service = services.First(o => o.GetType().Name == $"{brandEntity.Name}SmsService");

            if (service == null)
            {
                throw new InvalidOperationException($"Service type for brand {brandEntity.Name} not found.");
            }

            var smsCode = await service.GenerateSmsCode();

            var brandSettings = await _unitOfWork.GetRepository<BrandSettingEntity>().GetAllAsync(x => x.BrandId == brandId);
            return smsCode;
        }

        public async Task<string> SeatExtraMethod()
        {
            var service = _serviceProvider.GetRequiredService<ISeatSmsService>();
            return await service.ExtraSeatSmsMethod();
        }
    }
}
