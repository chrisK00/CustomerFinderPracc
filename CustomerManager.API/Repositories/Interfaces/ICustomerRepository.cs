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
        Task<CustomerDTO> GetCustomerByUsernameAsync(string username);
        Task<MemberDTO> GetMemberByUsernameAsync(string username);
        Task<ICollection<MemberDTO>> GetMembersAsync();
        Task AddAsync(Customer customer);
        void Remove(Customer customer);
        void Update(Customer customer);
    }
}
