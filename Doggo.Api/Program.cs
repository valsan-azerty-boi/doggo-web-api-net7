using Doggo.Infrastructure;
using MediatR;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "doggo-web-api-net7",
        Description = "Poc web api made with .NET 7 for some tests",
        Contact = new OpenApiContact
        {
            Name = "Source",
            Url = new Uri("https://github.com/valsan-azerty-boi/doggo-web-api-net7")
        }
    });
});

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IDoggoRepository, DoggoRepository>();
builder.Services.AddScoped<IDoggoBreedRepository, DoggoBreedRepository>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
