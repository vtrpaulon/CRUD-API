using ModuloAPI.Context;
using ModuloAPI.ModelsEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Agenda",
        Version = "v1"
    });
});

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); 
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Agenda v1");
        c.RoutePrefix = string.Empty; 
    });
}

app.UseHttpsRedirection();
app.MapControllers(); 

app.Run();

using ModuloAPI.Context;
using ModuloAPI.ModelsEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API de Agenda",
        Version = "v1"
    });
});


builder.Services.AddControllers();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); 
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de Agenda v1");
        c.RoutePrefix = string.Empty; 
    });
}

app.UseHttpsRedirection();
app.MapControllers(); 
app.Run();

