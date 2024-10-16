using FOI_labos_Blazor.Data;
using FOI_labos_Blazor.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FOI_labos_Blazor.Services;

public class TodoService(ApplicationDbContext context) : ITodoService
{
    public Task<List<Todo>> GetAllAsync()
    {
        return context.Todos.ToListAsync();
    }

    public async Task<Todo> GetByIdAsync(Guid id)
    {
        return await context.Todos.FirstOrDefaultAsync(todo => todo.Id == id);
    }

    public async Task CreateAsync(Todo model)
    {
        context.Todos.Add(model);
        await context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Todo model)
    {
        context.Todos.Update(model);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await context.Todos.FirstOrDefaultAsync(t => t.Id == id);
        context.Todos.Remove(entity!);
        await context.SaveChangesAsync();
    }
}