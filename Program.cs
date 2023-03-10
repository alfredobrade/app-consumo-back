using app_consumo.Context;
using app_consumo.ServiceInterfaces;
using app_consumo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//configuracion del inyector
// para inyectar una dependencia va arriba del builder
//con addScope se crea una nueva instancia a nivel de controlador
// con addSingleton se crea una unica instancia para toda la api
//builder.Services.AddScoped<IHelloWorldService,HelloWorldService>();
// otro metodo de inyectar una dependencia es
builder.Services.AddScoped<IHelloWorldService>(p => new HelloWorldService());
// en este caso tambien se puede pasar como parametro cosas al constructor

//hacemos la configuracion de inyeccion de los servicios
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddScoped<IRefuelingService, RefuelingService>();

//base de datos inMemory
builder.Services.AddDbContext<ConsumosContext>(p => p.UseInMemoryDatabase("ConsumosDB"));
// base de datos real
//builder.Services.AddSqlServer<ConsumosContext>(" ");
//conectando a una db de postgres
// verificar los puertos
//services.AddDbContext<HotelContextDB>(options => options.UseNpgsql(“Server=postgreServer;Database=DbName;Port=5432;User Id=user;Password=password;”));
//otro
//builder.Services.AddNpgsql<TareasContext>(builder.Configuration.GetConnectionString("TareasDb"));
/*
"ConnectionStrings": {
    "TareasDb" : "User ID=postgres;Password=postgrespw;Host=localhost;Port=55000;Database=TareasDb;"
  }
*/
//como yo levante un Docker de Postgres estoy utilizando el puerto 55000, pero por defecto el puerto de Postgres es 5423



var app = builder.Build();

// este es un middleware ??
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//estos son los middleware 

app.UseHttpsRedirection();

app.UseAuthorization();

// aca van los middleware customisados


//creando una conexion con base de datos InMemory
app.MapGet("/dbconexionim", async ([FromServices] ConsumosContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("base de datos en memoria: " + dbContext.Database.IsInMemory());
});

app.MapControllers();

app.Run();
