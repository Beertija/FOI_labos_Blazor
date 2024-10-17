using System.Reflection;
using FOI_labos_Blazor.Data;
using FOI_labos_Blazor.Services;
using FOI_labos_Blazor.Shared;
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

        services.AddControllers();
        services.AddSwaggerGen();

        services.AddAutoMapper(typeof(AutoMapperProfile).GetTypeInfo().Assembly);

        services.RegisterDomainServices();

        return services;
    }

    public static IServiceCollection RegisterDomainServices(this IServiceCollection services)
    {
        services.AddScoped<ITodoService, TodoService>();

        return services;
    }
}