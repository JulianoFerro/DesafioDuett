using DesafioDuett.Data;
using DesafioDuett.Repositorys;
using DesafioDuett.Repositorys.Interfaces;
using DesafioDuett.Services;
using DesafioDuett.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DesafioDuettDbContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DesafioDuett")));

builder.Services.AddScoped<IFruitRepository, FruitRepository>();
builder.Services.AddScoped<IFruitService, FruitService>();

builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
