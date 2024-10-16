using FOI_labos_Blazor.Data;
using FOI_labos_Blazor.Data.Models;

namespace FOI_labos_Blazor.Services;

public class TodoService(ApplicationDbContext context) : ITodoService
{
    public List<Todo> GetTodos()
    {
        return context.Todos.ToList();
    }

    public Todo GetById(Guid id)
    {
        return context.Todos.FirstOrDefault(todo => todo.Id == id);
    }

    public void Create(Todo model)
    {
        context.Todos.Add(model);
        context.SaveChanges();
    }

    public void Update(Todo model)
    {
        context.Todos.Update(model);
        context.SaveChanges();
    }

    public void Delete(Guid id)
    {
        var entity = context.Todos.FirstOrDefault(t => t.Id == id);
        context.Todos.Remove(entity);
        context.SaveChanges();
    }
}