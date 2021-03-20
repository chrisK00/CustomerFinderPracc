using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CustomerManager.API.Models;

namespace CustomerManager.API.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetByNameAsync(string name);
        Task<ICollection<Customer>> GetAllAsync();
        Task AddAsync(Customer customer);
        void Remove(Customer customer);
        void Update(Customer customer);
    }
}
