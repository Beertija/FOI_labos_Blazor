using FOI_labos_Blazor.Models;
using Microsoft.EntityFrameworkCore;

namespace FOI_labos_Blazor.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Todo> Todos { get; set; }
}