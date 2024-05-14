using Bogus;
using DotNetWebAPIWithMongoDB.DTOs;
using DotNetWebAPIWithMongoDB.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Diagnostics;

namespace DotNetWebAPIWithMongoDB.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]
public sealed class ValuesController : ControllerBase
{

    private readonly IMongoCollection<Todo> _todo;
    public ValuesController()
    {
        var client = new MongoClient("mongodb://127.0.0.1:27017");
        var database = client.GetDatabase("tododb");

        _todo = database.GetCollection<Todo>("todos");
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        // Fetch a certain number of Todo objects from the database
        var todos = await _todo.Find(todo => true).SortByDescending(s => s.Date).Limit(100).ToListAsync();
        return Ok(todos);
    }

    [HttpPost]
    public async Task<IActionResult> Save(TodoSaveDto request)
    {
        Todo todo = new()
        {
            Work = request.Value,
            Date = DateTime.Now.AddHours(3)
        };

        await _todo.InsertOneAsync(todo);
        return Ok(new { Message = "Todo successfully saved", TodoId = todo._id });
    }

    [HttpPost]
    public async Task<IActionResult> RemoveById(TodoRemoveDto request)
    {
        await _todo.FindOneAndDeleteAsync(f => f._id == request._Id);

        return Ok(new { Message = "Todo successfully removed" });
    }

    [HttpPost]
    public async Task<IActionResult> Update(TodoUpdateDto request)
    {
        var update = Builders<Todo>.Update.Set(t => t.Work, request.Value).Set(t => t.Date, DateTime.Now.AddHours(3));
        await _todo.FindOneAndUpdateAsync(f => f._id == request._Id, update);

        return Ok(new { Message = "Todo successfully updated" });
    }

    [HttpGet]
    public async Task<IActionResult> SeedAndMeasure()
    {
        List<Todo> todoList = new();
        for (int i = 0; i < 5; i++)
        {
            Faker faker = new();
            Todo todo = new()
            {
                Work = faker.Name.FullName(),
                Date = DateTime.Now.AddHours(3),
            };
            todoList.Add(todo);
        }

        var stopwatch = new Stopwatch();
        stopwatch.Start();
        await _todo.InsertManyAsync(todoList);
        var todos = await _todo.Find(todo => true).SortByDescending(s => s.Date).Limit(100).ToListAsync();
        stopwatch.Stop();

        var result = stopwatch.Elapsed.TotalMilliseconds; // Record the processing time
        Console.WriteLine(result);
        return Ok(new { Message = "Data seeded and fetched successfully", Duration = result, Data = todos });
    }

    [HttpGet]
    public async Task<IActionResult> RemoveAll()
    {
        await _todo.DeleteManyAsync(Builders<Todo>.Filter.Empty);
        return Ok(new { Message = "All todos have been deleted successfully" });
    }

}
