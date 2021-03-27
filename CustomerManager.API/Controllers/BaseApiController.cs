using Microsoft.AspNetCore.Mvc;

namespace CustomerManager.API.Controllers
{
    /// <summary>
    /// Dont want this to be reachable - marked abstract
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
    }
}