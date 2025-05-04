using RevisaoEcommerce.Data; 
using System.Text;
using Microsoft.EntityFrameworkCore; 
using RevisaoEcommerce.Models; 

var builder = WebApplication.CreateBuilder(args);

// Configuração da connection string
var connectionString = builder.Configuration.GetConnectionString("MySQL");

// Adiciona o contexto do banco de dados MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));


// Controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
