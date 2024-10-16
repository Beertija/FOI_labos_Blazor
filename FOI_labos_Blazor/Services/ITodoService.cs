using FOI_labos_Blazor.Data.Models;

namespace FOI_labos_Blazor.Services;

public interface ITodoService
{
    Task<List<Todo>> GetAllAsync();

    Task<Todo> GetByIdAsync(Guid id);

    Task CreateAsync(Todo model);

    Task UpdateAsync(Todo model);

    Task DeleteAsync(Guid id);
}