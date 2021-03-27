using System.Threading.Tasks;
using CustomerManager.API.Data;
using CustomerManager.API.Repositories.Interfaces;

namespace CustomerManager.API.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerContext _context;

        public UnitOfWork(CustomerContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveAsync()
        {
            //true if atleast 1 change has been made
            return await _context.SaveChangesAsync() > 0;
        }
    }
}