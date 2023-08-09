using Api.Models;
using MedisoftDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthenticationController : ControllerBase
    {
        public ILoginService LoginService { get; set; }
        public AuthenticationController(ILoginService loginService)
        {
            LoginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            return Ok(LoginService.Login(model));
        }
    }
}