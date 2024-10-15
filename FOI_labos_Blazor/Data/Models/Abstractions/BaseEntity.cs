using System.ComponentModel.DataAnnotations;

namespace FOI_labos_Blazor.Data.Models.Abstractions;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }
}