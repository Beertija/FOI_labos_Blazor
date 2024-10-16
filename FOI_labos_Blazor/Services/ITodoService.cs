using FOI_labos_Blazor.Data.Models;

namespace FOI_labos_Blazor.Services;

public interface ITodoService
{
    List<Todo> GetTodos();

    Todo GetById(Guid id);

    void Create(Todo model);

    void Update(Todo model);

    void Delete(Guid id);
}