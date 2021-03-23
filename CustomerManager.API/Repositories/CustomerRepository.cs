using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManager.API.Data;
using CustomerManager.API.Models;
using CustomerManager.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;

        public CustomerRepository(CustomerContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
        }
     
        public async Task<ICollection<Customer>> GetAllAsync()
        {
            //Todo
            //use automapper queryable extensions
            //split into two steps for easier debugging
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetByNameAsync(string name)
        {
            return await _context.Customers.SingleOrDefaultAsync(c => c.Name == name);
        }

        public void Remove(Customer customer)
        {
            _context.Customers.Remove(customer);
        }

        public void Update(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
        }
    }
}
