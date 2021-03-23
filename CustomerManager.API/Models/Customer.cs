using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManager.API.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //todo
        //move to dto
        public string Token { get; set; }
    }
}
