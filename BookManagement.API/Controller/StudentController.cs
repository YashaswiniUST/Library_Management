using BookManagement.API.Services;
using Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.API.Controller
{
    [ApiController]
    [Route("api/student")]
    public class StudentController:ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService=studentService;
        }
        [HttpGet("all-books")]

        public IActionResult GetAllBooks()
        {
            var books=_studentService.GetAllBooks();
            return Ok(books);
        }
        [HttpPost("request-book")]
        public IActionResult RequestBook(RequestBook dto)
        {
            _studentService.RequestBook(dto);
            return Ok("Request submitted successfullyy..!");
        }
        
    }
}