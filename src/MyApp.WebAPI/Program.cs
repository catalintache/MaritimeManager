using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Mapping;
using MyApp.Infrastructure.Repositories;
using MyApp.Application.Interfaces;
using MyApp.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt =>
  opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IShipService, ShipService>();
builder.Services.AddScoped<IVoyageService, VoyageService>();
builder.Services.AddScoped<IPortService, PortService>();
builder.Services.AddScoped<ICountryService, CountryService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger(); app.UseSwaggerUI();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();