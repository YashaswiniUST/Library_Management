using BookManagement.API.Models;
using BookManagement.API.Services;
using Contracts.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.API.Controller
{
    [ApiController]
    [Route("api/admin")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService adminService;
        public AdminController(IAdminService _adminService)
        {
            adminService=_adminService;
        }
        [HttpPost("add")]
        public IActionResult AddBook([FromBody] AllBooks book)
        {
            var result=adminService.CreateBook(book);
            return Ok(result);
        }
        [HttpDelete("{id}/delete")]
        public IActionResult DeleteBook(int id)
        {
            adminService.DeleteBook(id);
            return Ok();
        }
        [HttpPut("{id}/edit")]
        public IActionResult EditBook([FromBody] AllBooks book,int id)
        {
            var Editedbook=adminService.EditBook(book,id);
            return Ok(Editedbook);
        }
       [HttpPost("{id}/issue")]
public IActionResult IssueBook([FromBody] RequestBook dto,[FromRoute] int id)
{
    var issuedBook = adminService.IssueBook(dto,id);
    return Ok(issuedBook);
}


    }
}