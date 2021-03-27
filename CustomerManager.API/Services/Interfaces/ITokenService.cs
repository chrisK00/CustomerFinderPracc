using CustomerManager.API.DTOs;

namespace CustomerManager.API.Services.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(UserLoginDTO customer);
    }
}