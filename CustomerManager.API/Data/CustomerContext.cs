using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.API.Data
{
    public class CustomerContext : DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        
        //Todo
        //Add some relationships
    }
}
