using CRUD_API.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    ContentRootPath = Directory.GetCurrentDirectory(),
    EnvironmentName = Environments.Development // Garante que ele carrega appsettings.Development.json, se existir
});

// Configuração do banco de dados (mover para antes de builder.Build)
var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("A string de conexão não foi encontrada no appsettings.json.");
}

builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
