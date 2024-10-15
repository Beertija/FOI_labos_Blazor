using System.ComponentModel.DataAnnotations;
using FOI_labos_Blazor.Models.Abstractions;

namespace FOI_labos_Blazor.Models;

public class Todo : BaseEntity
{
    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    public bool IsCompleted { get; set; } = false;
}