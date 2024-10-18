using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using FOI_labos_Blazor.Shared;

namespace FOI_labos_Blazor.Client.HttpServices;

public class TodoService(HttpClient httpClient) : ITodoService
{
    private const string RequestUri = "/api/todo";

    public async Task<List<TodoDto>> GetAllAsync()
    {
        return await httpClient.GetFromJsonAsync<List<TodoDto>>(RequestUri);
    }

    public async Task<TodoDto> GetByIdAsync(Guid id)
    {
        return await httpClient.GetFromJsonAsync<TodoDto>($"{RequestUri}/{id}");
    }

    public async Task<HttpResponseMessage> CreateAsync(TodoDto value)
    {
        return await httpClient.PostAsJsonAsync(RequestUri, value);
    }

    public async Task<HttpResponseMessage> UpdateAsync(TodoDto value)
    {
        var jsonContent = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
        return await httpClient.PutAsync(RequestUri, jsonContent);
    }

    public async Task<HttpResponseMessage> DeleteAsync(Guid id)
    {
        return await httpClient.DeleteAsync($"{RequestUri}/{id}");
    }
}