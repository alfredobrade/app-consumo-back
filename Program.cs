using app_consumo.Services;

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

app.MapControllers();

app.Run();
