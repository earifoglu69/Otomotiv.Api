using Otomotiv.Infrastructure.Respositories;

namespace Otomotiv.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAsync<T> GetRepository<T>() where T : class;
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
