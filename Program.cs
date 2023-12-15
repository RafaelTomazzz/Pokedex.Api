using Pokedex.Api.Data;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Repositories;
using Pokedex.Api.Repositories.Interfaces;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalRafael"));
});

builder.Services.AddScoped<IEvolucoesRepository, EvolucoesRepository>();

builder.Services.AddScoped<IHabilidadesRepository, HabilidadesRepository>();

builder.Services.AddScoped<IItensRepository, ItensRepository>();

builder.Services.AddScoped<IPokemonHabilidadesRepository, PokemonHabilidadesRepository>();

builder.Services.AddScoped<IPokemonsRepository, PokemonsRepository>();

builder.Services.AddScoped<ITreinadoresRepository, TreinadoresRepository>();


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
