using Microsoft.EntityFrameworkCore;
using FitLife.Persistence.Data;

var builder = WebApplication.CreateBuilder(args);

// FitLifeDbContext setup from Persistence project
builder.Services.AddDbContext<FitLifeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
