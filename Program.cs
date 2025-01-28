using ModuloAPI.Context;
using ModuloAPI.ModelsEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Adicionar o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Agenda",
        Version = "v1"
    });
});

// Adicionar o servi�o de Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configurar o pipeline do Swagger (Somente em Desenvolvimento)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita o Swagger
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Agenda v1");
        c.RoutePrefix = string.Empty; // Se voc� quiser que o Swagger seja a p�gina inicial
    });
}

app.UseHttpsRedirection();
app.MapControllers(); // Mapeia os controllers

app.Run();

using ModuloAPI.Context;
using ModuloAPI.ModelsEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

// Adicionar o Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Agenda",
        Version = "v1"
    });
});

// Adicionar o servi�o de Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configurar o pipeline do Swagger (Somente em Desenvolvimento)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita o Swagger
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Agenda v1");
        c.RoutePrefix = string.Empty; // Se voc� quiser que o Swagger seja a p�gina inicial
    });
}

app.UseHttpsRedirection();
app.MapControllers(); // Mapeia os controllers

app.Run();

