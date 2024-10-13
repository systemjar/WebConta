using Microsoft.EntityFrameworkCore;
using WebConta.Backend.Data;
using WebConta.Backend.Repositories.Implementations;
using WebConta.Backend.Repositories.Interfaces;
using WebConta.Backend.UnitOfWork.Implementations;
using WebConta.Backend.UnitOfWork.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyectamos el servicio para conectarse al SqlServer
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer("name=CadenaSql"));

//Inyectamos Los genericos del Repositorio y del UnitOfWork
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepositoryy<>));
builder.Services.AddScoped(typeof(IGenericUnitOfWork<>), typeof(GenericUnitOfWork<>));

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

//Para confiugurar la seguridad del api
app.UseCors(x => x
    .AllowCredentials() //Cualquier credencial
    .AllowAnyHeader()   //Para permitir el envio de cualquier header
    .AllowAnyMethod()   //Cualquiera puede consumir cualquier metodo
    .SetIsOriginAllowed(origin => true)); //Si no se pone esta linea no va a funcionar
app.Run();