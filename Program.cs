using Microsoft.EntityFrameworkCore;
using DotNetEnv;
using database;

var AllowSpecificOrigins = "AllowFrontEnd";

var builder = WebApplication.CreateBuilder(args);

Env.Load();

builder.Services.AddControllers();

var connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connection)
);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSpecificOrigins, policy =>
    {
        policy.WithOrigins(
                "http://futurofrontend.com", 
                "http://localhost"
            ).AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors(AllowSpecificOrigins);

app.MapControllers();

app.MapGet("/api", () =>
{
   return Results.Ok("Tudo certo porraaa"); 
});

app.Run();