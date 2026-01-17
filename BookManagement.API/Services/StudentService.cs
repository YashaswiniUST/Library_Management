using BookManagement.API.Data;
using BookManagement.API.Models;

using Contracts.DTOs;

namespace BookManagement.API.Services
{
    public class StudentService : IStudentService
    {
        private readonly AppDbContext _context;
        public StudentService(AppDbContext context)
        {
            _context=context;
        }
        public List<AllBooks> GetAllBooks()
        {
           return _context.Books.Select(b=>new AllBooks
           {
               BookName=b.BookName,
               ImageUrl=b.ImageUrl,
               Author=b.Author,
               Description=b.Description,
               Copies=b.Copies
           }).ToList();
        }

        public Issue RequestBook(RequestBook dto)
        {
            var book=_context.Books.FirstOrDefault(b=>b.BookId==dto.BookId);
            var student=_context.Students.FirstOrDefault(b=>b.StudentId==dto.studentId);
            var issue=new Issue
            {
                BookId=dto.BookId,
                status=Contracts.Enums.Status.Pending
            };
            _context.Issues.Add(issue);
            _context.SaveChanges();
            return issue;
        }
    }
}