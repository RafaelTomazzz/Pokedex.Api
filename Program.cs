using Pokedex.Api.Data;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Repositories;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Services.Interfaces;
using Pokedex.Api.Services;
using Pokedex.Api.Repositories.UnitOfWork;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalRafael"));
});

builder.Services.AddScoped<IEvolucoesRepository, EvolucoesRepository>();
builder.Services.AddScoped<IEvolucoesService, EvolucoesServices>();

builder.Services.AddScoped<IHabilidadesRepository, HabilidadesRepository>();
builder.Services.AddScoped<IHabilidadesService, HabilidadesService>();

builder.Services.AddScoped<IItensRepository, ItensRepository>();
builder.Services.AddScoped<IItensService, ItensService>();

builder.Services.AddScoped<IPokemonHabilidadesRepository, PokemonHabilidadesRepository>();
builder.Services.AddScoped<IPokemonHabilidadesService, PokemonHabilidadesService>();

builder.Services.AddScoped<IPokemonsRepository, PokemonsRepository>();
builder.Services.AddScoped<IPokemonsService, PokemonsService>();

builder.Services.AddScoped<ITreinadoresRepository, TreinadoresRepository>();
builder.Services.AddScoped<ITreinadoresService, TreinadoresService>();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
