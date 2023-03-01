using Microsoft.AspNetCore.Mvc;

namespace app_consumo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    //se crea una collection con datos
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;


    //crea una coleccion estatica para trabajar datos en memoria
    // esto lo hace para poder trabajar con los datos que se generan al iniciar
    private static List<WeatherForecast> ListWeatherForecast = new List<WeatherForecast>();

    // este metodo es el constructor del controlador
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;

        //agrega una pregunta si la lista es nula o si no tiene nada
        if(ListWeatherForecast == null || !ListWeatherForecast.Any())
        {   
            //copia el codigo del Get de abajo y lo asigna a la lista que creamos
            ListWeatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToList();
            //.ToArray(); cambia el ToArray por un ToList porque se lo esta asignando a una lista
        }
    }


    //crea un endpoint 
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        // devuelve un random de 4 5 elementos
        //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //{
        //    Date = DateTime.Now.AddDays(index),
        //    TemperatureC = Random.Shared.Next(-20, 55),
        //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //})
        //.ToArray();

        return ListWeatherForecast;
    }


    //creamos el metodo post
    [HttpPost]
    [Route("[action]")]
    public IActionResult Post(WeatherForecast weatherForecast)
    {
        ListWeatherForecast.Add(weatherForecast);   
        return Ok();

    }

    //creamos el metodo delet
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        ListWeatherForecast.RemoveAt(id);
        return Ok();

    }
}
