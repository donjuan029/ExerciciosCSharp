using APIProdutos.Contexts;
using APIProdutos.Interfaces;
using APIProdutos.Repositories;
using APIProdutos.Services;
using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

string? connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");

if(string.IsNullOrWhiteSpace(connectionString))
{
    throw new Exception("Connection não encontrada.");
}

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registra conexão cm o banco (DBContext -> ProdutoContext)
builder.Services.AddDbContext<ProdutoContext>(options => options.UseSqlServer(connectionString));

// Injeção de dependências
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<ProdutoService>();

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
