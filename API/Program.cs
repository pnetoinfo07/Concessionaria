using Dominio._01_Core.Interfaces.Repository;
using Dominio._01_Core.Interfaces.Services;
using Dominio._02_Repository;
using Dominio._03_Services;
using TrabalhoFinal._03_Entidades.DTOs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
InicializadorBD.Inicializar();
builder.Services.AddScoped<ICarroRespository, CarroRepository>();
builder.Services.AddScoped<ICarroService, CarroService>();
builder.Services.AddScoped<ICaminhaoRepository, CaminhaoRepository>();
builder.Services.AddScoped<ICaminhaoService, CaminhaoService>();
builder.Services.AddAutoMapper(typeof(MappingProfile));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
