using BookManagement.API.Data;
using BookManagement.API.Models;
using Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.API.Services
{
    public class AdminService : IAdminService
    {
        private readonly AppDbContext _context;
        public AdminService(AppDbContext context)
        {
            _context=context;
        }

        public Book CreateBook(AllBooks dto)
        {
           var book=new Book
           {
               BookName=dto.BookName,
               ImageUrl=dto.ImageUrl,
               Author=dto.Author,
               Description=dto.Description,
               Copies=dto.Copies
           };
           _context.Books.Add(book);
           _context.SaveChanges();
           return book;
        }

        public void DeleteBook(int bookid)
        {
            var book=_context.Books.FirstOrDefault(e=>e.BookId==bookid);
           var removedBook= _context.Books.Remove(book);
            _context.SaveChanges();
            
        }

        public Book EditBook(AllBooks dto,int id)
        {
            var book=_context.Books.Find(id);
               
                book.BookName=dto.BookName;
                book.Author=dto.Author;
                book.Description=dto.Description;
                book.ImageUrl=dto.ImageUrl;
                book.Copies=dto.Copies;
                
            _context.SaveChanges();
            return book;
        }
[HttpPut("issue")]
public Issue IssueBook([FromBody] RequestBook dto,[FromQuery]int id)
{
    var issue=_context.Issues.Find(id);
    issue.status=Contracts.Enums.Status.Issued;
    _context.Issues.Add(issue);
    _context.SaveChanges();

    return issue;
}

    }
}