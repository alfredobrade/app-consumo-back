using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_consumo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;


        private UserController(ILogger<UserController> logger)
        {
            _logger = logger;

            // aca podemos hacer una lista pára manejar los datos

        }

        //get 
        [HttpGet]
        [Route("GetUser")]
        public IEnumerable<User> Get()
        {

            return new List<User>(); // cual es la diferencia de terminar con () o con {} ???


        }

        //post
        [HttpPost]
        public IActionResult Post(User user)
        {

            //aca agregamos a la lista con .Add(user)


            return Ok();
        }

        //delete
        [HttpDelete("{index}")] // aclaramos que dentro de la URL va el index para eliminar de la lista
        [Route("[action]")] //sirve para usar el nombre del metodo en la url
        public IActionResult Delete(int i) //index de la lista para eliminar
        {

            // eliminar de la lista con .RemoveAt(i)

            return Ok();
        }

    }
}