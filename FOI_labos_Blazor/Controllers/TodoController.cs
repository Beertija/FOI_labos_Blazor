using FOI_labos_Blazor.Data.Models;
using FOI_labos_Blazor.Services;
using Microsoft.AspNetCore.Mvc;

namespace FOI_labos_Blazor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController(ITodoService service) : ControllerBase
{
    [HttpGet]
    public async Task<List<Todo>> GetAllAsync()
    {
        return await service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<Todo> GetByIdAsync(Guid id)
    {
        return await service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task CreateAsync([FromBody] Todo value)
    {
        await service.CreateAsync(value);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Todo value)
    {
        await service.UpdateAsync(value);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(Guid id)
    {
        await service.DeleteAsync(id);
    }
}