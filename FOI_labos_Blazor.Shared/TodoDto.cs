namespace FOI_labos_Blazor.Shared;

public record TodoDto
{
    public Guid Id { get; init; }
    public string Title { get; init; }
    public bool IsCompleted { get; init; }
}