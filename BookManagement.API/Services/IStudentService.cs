using BookManagement.API.Models;
using Contracts.DTOs;

namespace BookManagement.API.Services
{
    public interface IStudentService
    {
        public List<AllBooks> GetAllBooks();
        public Issue RequestBook(RequestBook dto);
    }
}