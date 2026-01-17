using BookManagement.API.Models;

using Contracts.DTOs;

namespace BookManagement.API.Services
{
    public interface IAdminService
    {
        public Book CreateBook(AllBooks dto);
        public Book EditBook(AllBooks book,int id);
        public Issue IssueBook(RequestBook dto,int id);
        public void DeleteBook(int bookid);
    }
}