using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CustomerManager.API.DTOs;
using CustomerManager.API.Models;

namespace CustomerManager.API.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task<AppUser> GetCustomerAsync(int id);
        Task<UserDTO> GetCustomerByUsernameAsync(string username);
        Task<CustomerDTO> GetMemberByUsernameAsync(string username);
        Task<ICollection<CustomerDTO>> GetMembersAsync();
        Task AddAsync(AppUser customer);
        void Remove(AppUser customer);
        void Update(AppUser customer);
    }
}
