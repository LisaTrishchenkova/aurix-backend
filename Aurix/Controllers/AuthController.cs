using Microsoft.AspNetCore.Mvc;
using Aurix.Models.Requests;

namespace Aurix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        // ".../api/auth/login" 
        [HttpPost("login")]
        public IActionResult Login(
            [FromBody] LoginRequest request
            )
        {

            return Ok();
        }

        // ".../api/auth/registration"
        [HttpPost("registration")]
        public IActionResult Registration(
            [FromBody] RegistrationRequest request
        )
        {
            return Ok();
        }
    }
}