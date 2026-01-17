using Contracts.DTOs;

namespace BookManagement.API.Services
{
    public interface IStudentAuthService
    {
        public void HandleRegister(RegisterDto dto);
        public LoginDto HandleLogin(LoginDto dto);
    }
}