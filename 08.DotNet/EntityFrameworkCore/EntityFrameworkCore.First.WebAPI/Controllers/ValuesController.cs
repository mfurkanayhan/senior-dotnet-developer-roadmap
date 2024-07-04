using EntityFrameworkCore.First.WebAPI.Context;
using EntityFrameworkCore.First.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCore.First.WebAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpDelete] // HttpGet

    public IActionResult Delete(string work, DateTime date)
    {
        Todo todo = new()
        {
            Work = work,
            DateToBeCompleted = date,
            CreatedDate = DateTime.Now
        };

        ApplicationDbContext context = new();
        context.Add(todo);
        context.SaveChanges();
        return Ok(new { Message = "The deletion process was successfully completed" });
    }

    [HttpPut] // HttpPost
    public IActionResult Update(AddTodoDto addTodoDto)
    {
        //Todo todo = new()
        //{
        //    Work = addTodoDto.Work,
        //    DateToBeCompleted = addTodoDto.DateToBeCompleted,
        //    CreatedDate = DateTime.Now
        //};

        //ApplicationDbContext context = new();
        //context.Add(todo);
        //context.SaveChanges();

        return Ok(new { Message = "The update process was successfully completed" });
        }
}
