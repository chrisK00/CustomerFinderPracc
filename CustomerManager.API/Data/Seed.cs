using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using CustomerManager.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.API.Data
{
    public static class Seed
    {
        public static async Task SeedCustomersAsync(CustomerContext context)
        {
            if (await context.Customers.AnyAsync())
            {
                return;
            }
            var customerData = await File.ReadAllTextAsync("Data/CustomerSeedData.json");
            var customers = JsonSerializer.Deserialize<List<Customer>>(customerData);

            await context.AddRangeAsync(customers);
            await context.SaveChangesAsync();
        }
    }
}
