using AutoMapper;
using FOI_labos_Blazor.Data;
using FOI_labos_Blazor.Data.Models;
using FOI_labos_Blazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace FOI_labos_Blazor.Services;

public class TodoService(ApplicationDbContext context, IMapper mapper) : ITodoService
{
    public async Task<List<TodoDto>> GetAllAsync()
    {
        var result = await context.Todos.ToListAsync();
        return mapper.Map<List<TodoDto>>(result);
    }

    public async Task<TodoDto> GetByIdAsync(Guid id)
    {
        var result = await context.Todos.FirstOrDefaultAsync(todo => todo.Id == id);
        return mapper.Map<TodoDto>(result);
    }

    public async Task CreateAsync(TodoDto model)
    {
        var entity = mapper.Map<Todo>(model);
        context.Todos.Add(entity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TodoDto model)
    {
        var entity = mapper.Map<Todo>(model);
        context.Todos.Update(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await context.Todos.FirstOrDefaultAsync(t => t.Id == id);
        context.Todos.Remove(entity!);
        await context.SaveChangesAsync();
    }
}