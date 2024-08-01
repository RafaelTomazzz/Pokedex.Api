using Pokedex.Api.Data;
using Microsoft.EntityFrameworkCore;
using Pokedex.Api.Repositories;
using Pokedex.Api.Repositories.Interfaces;
using Pokedex.Api.Services.Interfaces;
using Pokedex.Api.Services;
using Pokedex.Api.Repositories.UnitOfWork;
using Pokedex.Api.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Pokedex;
using Microsoft.AspNetCore.Authentication.JwtBearer;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("LocalRafael"));
});

builder.Services.AddScoped<IEvolucoesRepository, EvolucoesRepository>();
builder.Services.AddScoped<IEvolucoesService, EvolucoesService>();

builder.Services.AddScoped<IHabilidadesRepository, HabilidadesRepository>();
builder.Services.AddScoped<IHabilidadesService, HabilidadesService>();

builder.Services.AddScoped<IItensRepository, ItensRepository>();
builder.Services.AddScoped<IItensService, ItensService>();

builder.Services.AddScoped<IPokemonHabilidadesRepository, PokemonHabilidadesRepository>();
builder.Services.AddScoped<IPokemonHabilidadesService, PokemonHabilidadesService>();

builder.Services.AddScoped<IEvolucaoHabilidadeRepository, EvolucaoHabilidadeRepository>();
builder.Services.AddScoped<IEvolucaoHabilidadeService, EvolucaoHabilidadeService>();

builder.Services.AddScoped<IPokemonsRepository, PokemonsRepository>();
builder.Services.AddScoped<IPokemonsService, PokemonsService>();

builder.Services.AddScoped<ITreinadoresRepository, TreinadoresRepository>();
builder.Services.AddScoped<ITreinadoresService, TreinadoresService>();

builder.Services.AddScoped<IPokemonTreinadoresRepository, PokemonTreinadoresRepository>();
builder.Services.AddScoped<IPokemonTreinadoresService, PokemonTreinadoresService>();

builder.Services.AddScoped<IEvolucaoTreinadoresRepository, EvolucaoTreinadoresRepository>();
builder.Services.AddScoped<IEvolucaoTreinadoresService, EvolucaoTreinadoresService>();

builder.Services.AddScoped<IItemTreinadoresRepository, ItemTreinadoresRepository>();
builder.Services.AddScoped<IItemTreinadoresService, ItemTreinadoresService>();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddCors();
builder.Services.AddControllers();

var key = Encoding.ASCII.GetBytes(Settings.Secret);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});

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
