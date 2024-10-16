using FOI_labos_Blazor.Components;
using FOI_labos_Blazor.Data;
using Microsoft.EntityFrameworkCore;

namespace FOI_labos_Blazor.Configuration;

public static class WebApplicationExstensions
{
    public static WebApplication Configure(this WebApplication app, IWebHostEnvironment environment,
        IConfiguration configuration)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        else
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAntiforgery();
        app.MapControllers();

        app.MapRazorComponents<App>()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

        return app;
    }

    /// <summary>
    /// Apply migrations - kako bismo imali pripremljenu bazu sa svim potrebnim tablicama
    /// </summary>
    /// <param name="app"></param>
    /// <returns></returns>
    public static WebApplication MigrateDatabase(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        context.Database.Migrate();

        return app;
    }
}