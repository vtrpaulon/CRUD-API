using CRUD_API.Context;
using CRUD_API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Configuração do banco de dados (mover para antes de builder.Build)
var connectionString = builder.Configuration.GetConnectionString("ConexaoPadrao");

//Registrar Repositories
builder.Services.AddScoped<IContatoRepository,ContatoRepository>();

if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("A string de conexão não foi encontrada no appsettings.json.");
} else {
    builder.Services.AddDbContext<AgendaContext>(options => options.UseSqlServer(connectionString));
}

var app = builder.Build();

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
