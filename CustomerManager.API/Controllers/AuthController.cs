using CustomerManager.API.DTOs;
using CustomerManager.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CustomerManager.API.Controllers
{
    public class AuthController : BaseApiController
    {
        private readonly ITokenService _tokenService;
        private readonly ILogger<AuthController> _logger;

        public AuthController(ITokenService tokenService, ILogger<AuthController> logger)
        {
            _tokenService = tokenService;
            _logger = logger;
        }

        [HttpPost("login")]
        public ActionResult<UserDTO> Login(UserLoginDTO customer)
        {
            //Todo
            //setup identity framework 
            //authenticate

            var token = _tokenService.CreateToken(customer);
            _logger.LogInformation($"New token created for {customer.Username}", token);

            return new UserDTO
            {
                Username = customer.Username,
                Token = token
            };
        }
    }
}
