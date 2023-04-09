using CretaceousApi.Models;
using Microsoft.EntityFrameworkCore;

// uses implicit using directives and top level statements

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// there are no views in api, so we only add controllers as a service
builder.Services.AddControllers();
// The builder.Services.AddEndpointsApiExplorer(); code enables Swagger documentation to do its job; it exposes our API's endpoints for documentation and other things.

builder.Services.AddDbContext<CretaceousApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], 
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddEndpointsApiExplorer();
// Swagger is a service that automatically documents the available endpoints in our application.
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// if statement checks if our application is being run in a development environment, and if so configures our HTTP pipeline to actually use Swagger and Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
