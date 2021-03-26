using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.API.DTOs;
using CustomerManager.API.Models;

namespace CustomerManager.API.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(UserLoginDTO customer);
    }
}
