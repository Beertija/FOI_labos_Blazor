using FOI_labos_Blazor.Data.Models;
using FOI_labos_Blazor.Services;
using Microsoft.AspNetCore.Mvc;

namespace FOI_labos_Blazor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController(ITodoService service) : ControllerBase
{
    [HttpGet]
    public IEnumerable<Todo> Get()
    {
        return service.GetTodos();
    }

    [HttpGet("{id}")]
    public Todo Get(Guid id)
    {
        return service.GetById(id);
    }

    [HttpPost]
    public void Post([FromBody] Todo value)
    {
        service.Create(value);
    }

    [HttpPut]
    public void Put([FromBody] Todo value)
    {
        service.Update(value);
    }

    [HttpDelete("{id}")]
    public void Delete(Guid id)
    {
        service.Delete(id);
    }
}