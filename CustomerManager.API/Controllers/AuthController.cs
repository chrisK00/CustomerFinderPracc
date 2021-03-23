using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManager.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManager.API.Controllers
{
    public class AuthController : BaseApiController
    {
        [HttpPost("login")]
        public ActionResult<Customer> Login()
        {
            //Todo
            //send back a jwt token

            return Ok();
        }
    }
}
