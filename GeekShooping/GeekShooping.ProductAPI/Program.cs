using GeekShooping.ProductAPI.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Obtem a string de conexão
var connection = builder.Configuration["SqlServerConnection:SqlServerConnectionString"];

// Adiciona o DbContext com o Pomelo
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connection));

// Outros serviços
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "GeekShopping.ProductAPI",
        Version = "v1"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
