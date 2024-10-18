using FOI_labos_Blazor.Services;
using FOI_labos_Blazor.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FOI_labos_Blazor.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodoController(ITodoService service) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<TodoDto>>> GetAllAsync()
    {
        return await service.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TodoDto>> GetByIdAsync(Guid id)
    {
        return await service.GetByIdAsync(id);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync([FromBody] TodoDto value)
    {
        await service.CreateAsync(value);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync([FromBody] TodoDto value)
    {
        await service.UpdateAsync(value);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        await service.DeleteAsync(id);
        return Ok();
    }
}