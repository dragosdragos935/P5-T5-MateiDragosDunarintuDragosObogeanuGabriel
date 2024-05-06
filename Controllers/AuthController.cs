using Microsoft.AspNetCore.Mvc;
using aplicatie.Models;
namespace aplicatie.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User model)
        {
            bool isAuthenticated = _authService.Authenticate(model.Username, model.Password);
            if (isAuthenticated)
            {
                return Ok("Login successful!");
            }
            return Unauthorized("Invalid username or password");
        }
    }

}
