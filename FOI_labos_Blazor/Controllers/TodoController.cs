using FOI_labos_Blazor.Data;
using FOI_labos_Blazor.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FOI_labos_Blazor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet]
    public IEnumerable<Todo> Get()
    {
        return context.Todos;
    }

    [HttpGet("{id}")]
    public Todo Get(Guid id)
    {
        return context.Todos.FirstOrDefault(todo => todo.Id == id);
    }

    [HttpPost]
    public void Post([FromBody] Todo value)
    {
        context.Todos.Add(value);
        context.SaveChanges();
    }

    [HttpPut]
    public void Put([FromBody] Todo value)
    {
        context.Todos.Update(value);
        context.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        var entity = context.Todos.FirstOrDefault(t => t.Id == id);
        context.Todos.Remove(entity);
        context.SaveChanges();
    }
}