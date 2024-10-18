using FOI_labos_Blazor.Shared;

namespace FOI_labos_Blazor.Client.HttpServices;

public interface ITodoService
{
    Task<List<TodoDto>> GetAllAsync();

    Task<TodoDto> GetByIdAsync(Guid id);

    Task<HttpResponseMessage> CreateAsync(TodoDto value);

    Task<HttpResponseMessage> UpdateAsync(TodoDto value);

    Task<HttpResponseMessage> DeleteAsync(Guid id);
}