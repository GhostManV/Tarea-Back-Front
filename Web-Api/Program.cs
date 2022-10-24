using Microsoft.EntityFrameworkCore;
using Web_Api.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Agregar Cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<dbempleadoContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConection"), Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllowAll");
app.MapControllers();

app.Run();
