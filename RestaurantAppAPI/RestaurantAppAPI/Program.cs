using Microsoft.EntityFrameworkCore;
using RestaurantAppAPI.Generated;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IConfigurationBuilder buildConfig = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
IConfiguration configuration = buildConfig.Build();
builder.Services.AddDbContext<RestaurantAppDB>(options =>
options.UseSqlServer(configuration.GetConnectionString("RestaurantAppDB")));

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
