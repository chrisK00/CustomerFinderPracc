using System.Threading.Tasks;

namespace CustomerManager.API.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}