using EntityFrameworkCore.First.WebAPI.Context;
using EntityFrameworkCore.First.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace EntityFrameworkCore.First.WebAPI.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public class TodosController(ApplicationDbContext context) : ControllerBase
{
    [HttpPost]

    public IActionResult Add(AddTodoDto request)
    {
        Todo todo = new()
        {
            Work = request.Work.Trim(),
            DateToBeCompleted = request.DateToBeCompleted,
            CreatedDate = DateTime.Now
        };

        context.Add(todo);

        context.SaveChanges();

        return Ok(new { Id = todo.Id });
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        IEnumerable<Todo> todos = context.Todos.OrderByDescending(p => p.CreatedDate).ToList();
        return Ok(todos);
    }

    [HttpGet]
    public IActionResult GetById(int id) 
    {
        Todo? todo = context.Todos.Find(id);

        if(todo is null)
        {
            return BadRequest(new { Message = "Todo record not found!" });
        }

        return Ok(todo);
    }

    [HttpGet]
    public IActionResult GetByWork(string work)
    {
        IEnumerable<Todo> todos = context.Todos.Where(p => p.Work.ToLower().Contains(work.ToLower())).ToList();

        return Ok(todos);
    }

    [HttpPost]
    public IActionResult GetByExpression(Expression<Func<Todo, bool>> expression)
    {
        IEnumerable<Todo> todos = context.Todos.Where(expression).ToList();

        return Ok(todos);
    }

    [HttpPost("{id}")]
    public IActionResult Update(int id, UpdateTodoDto request)
    {
        Todo? todo = context.Todos.Find(id);

        if (todo is null)
        {
            return BadRequest(new { Message = "Todo record not found!" });
        }

        todo.Work = request.Work;
        todo.DateToBeCompleted = request.DateToBeCompleted;

        context.SaveChanges();

        return Ok(new { Id = todo.Id });
    }

    [HttpGet]
    public IActionResult ChangeCompletedStatus(int id)
    {
        Todo? todo = context.Todos.Find(id);

        if (todo is null)
        {
            return BadRequest(new { Message = "Todo record not found" });
        }

        todo.IsCompleted = !todo.IsCompleted;
        todo.DateCompleted = todo.IsCompleted == false ? null : DateTime.Now;
    
        context.SaveChanges();

        return NoContent();
    }

    [HttpGet("{id}")]
    public IActionResult RemoveById(int id)
    {
        Todo? todo = context.Todos.Find(id);

        if(todo is null)
        {
            return BadRequest(new { Message = "Todo kaydı bulunamadı" });
        }

        context.Remove(todo);
        context.SaveChanges();

        return NoContent();
    }
}


public sealed class TodoDto
{
    public string Work { get; set; } = string.Empty;
    public DateTime DateToBeCompleted { get; set; }
}

public sealed class AddTodoDto
{
    public string Work { get; set; } = string.Empty;
    public DateTime DateToBeCompleted { get; set; }
}

public sealed class UpdateTodoDto
{
    public string Work { get; set; } = string.Empty;
    public DateTime DateToBeCompleted { get; set; }
}

