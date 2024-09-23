namespace Otomotiv.Application.Services
{
    public interface ISmsService
    {
        Task<string> GenerateCustomerSmsCode(int brandId);
        Task<string> AudiExtraMethod();
        Task<string> SeatExtraMethod();

    }
}
