using API3.Data;
using API3.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddSqlServer<DanielCornejoDbContext>(builder.Configuration.GetConnectionString("BurgerConnection"));

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapBurgerEndpoints();

app.Run();
