using CustomerManager.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.API.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
