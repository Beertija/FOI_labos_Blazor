using FOI_labos_Blazor.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices(builder.Configuration);

var app = builder.Build();

app.Configure(app.Environment, builder.Configuration)
    .MigrateDatabase()
    .Run();