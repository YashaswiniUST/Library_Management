using BookManagement.API.Services;
using Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.API.Controller
{
    [ApiController]
    [Route("api/auth/student")]
    public class StudentAuthController : ControllerBase
    {
        private readonly IStudentAuthService _authService;
        public StudentAuthController(IStudentAuthService authService)
        {
            _authService=authService;   
        }
        [HttpPost("/register-student")]
        public IActionResult Register([FromBody] RegisterDto dto)
        {
            _authService.HandleRegister(dto);
            return Ok("registration successfull..!!");
        }
        [HttpPost("/login-student")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            var login=_authService.HandleLogin(dto);
            return Ok(login);

        }
    }
}