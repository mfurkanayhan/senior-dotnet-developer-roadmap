﻿using EntityFrameworkCore.First.WebAPI.Context;
using EntityFrameworkCore.First.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkCore.First.WebAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LINQController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        //ApplicationDbContext context = new();
        //List<Todo> todos = context.Todos.ToList();
        //context.Set<Todo>().ToList();

        //List<string> names = new();
        //names.Add("Furkan");
        //names.Remove("Furkan");
        //List<string> newNames = names.Where(p => p == "Furkan").ToList();
        //string? newName = names.FirstOrDefault(p => p == "Furkan");
        //string? newName2 = names.SingleOrDefault(p => p == "Furkan");
        //string? newName3 = names.Where(p => p == "Furkan").FirstOrDefault();

        //List<Example> examples = new();
        //var newExample = examples.Select(p => new NewExample()
        //{
        //    Name = string.Join(", ", p.FirstName, p.LastName),
        //    Age = p.Age,
        //    City = "Zonguldak"
        //}).ToList();

        //int result = examples.Sum(p => p.Age);

        //int count = examples.Count();

        //ApplicationDbContext context = new();

        //var todos = context.Todos.AsQueryable();

        //todos.Where(p => p.IsCompleted);

        return Ok();
    }
}

// LINQ Language Integrated Query
public class Example
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
}

public class NewExample
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string City { get; set; } = string.Empty;
}