using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CustomerManager.API.Data;
using CustomerManager.API.DTOs;
using CustomerManager.API.Models;
using CustomerManager.API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(CustomerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<AppUser> GetCustomerAsync(int id)
        {
            var customer = await _context.AppUsers.Include(p => p.Photos).FirstOrDefaultAsync(c => c.Id == id);
            return customer;
        }

        public async Task<ICollection<CustomerDTO>> GetMembersAsync()
        {           
            var members = await _context.AppUsers.ProjectTo<CustomerDTO>(_mapper.ConfigurationProvider).ToListAsync();
            return members;
        }

        public async Task<UserDTO> GetCustomerByUsernameAsync(string username)
        {
           var customer = await _context.AppUsers
                .Where(c => c.Username == username)
                .ProjectTo<UserDTO>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
            return customer;
        }

        public async Task<CustomerDTO> GetMemberByUsernameAsync(string username)
        {
            var customer = await _context.AppUsers
                 .Where(c => c.Username == username)
                 .ProjectTo<CustomerDTO>(_mapper.ConfigurationProvider).SingleOrDefaultAsync();
            return customer;
        }

        public void Remove(AppUser customer)
        {
            _context.AppUsers.Remove(customer);
        }

        public async Task AddAsync(AppUser customer)
        {
            await _context.AppUsers.AddAsync(customer);
        }

        public void Update(AppUser customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
        }
    }
}
