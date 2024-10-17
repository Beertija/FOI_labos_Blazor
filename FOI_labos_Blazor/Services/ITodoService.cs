using FOI_labos_Blazor.Shared;

namespace FOI_labos_Blazor.Services;

public interface ITodoService
{
    Task<List<TodoDto>> GetAllAsync();

    Task<TodoDto> GetByIdAsync(Guid id);

    Task CreateAsync(TodoDto model);

    Task UpdateAsync(TodoDto model);

    Task DeleteAsync(Guid id);
}