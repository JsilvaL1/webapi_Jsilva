using Microsoft.EntityFrameworkCore;
using UniversitaryApiSqlServer.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("No se encontró la cadena de conexión.");

builder.Services.AddDbContext<UniversitaryDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapGet("/", () => new
{
    mensaje = "UniversitaryApiSqlServer funcionando",
    proveedor = "Entity Framework Core para SQL Server",
    baseDeDatos = "UniversitaryStudySqlServerDB"
});

app.MapControllers();

app.Run();