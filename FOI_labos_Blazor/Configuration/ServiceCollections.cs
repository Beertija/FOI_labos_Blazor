using FOI_labos_Blazor.Data;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

namespace FOI_labos_Blazor.Configuration;

public static class ServiceCollections
{
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMudServices();

        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddRazorComponents()
            .AddInteractiveWebAssemblyComponents();

        return services;
    }
}