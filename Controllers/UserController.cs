using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Models;
using app_consumo.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace app_consumo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        IUserService userService;

        public UserController(IUserService service)
        {
            userService = service;
        }
        

        //get 
        [HttpGet]
        [Route("GetUser")]
        public IActionResult Get()
        {

            return Ok(userService.Get());

        }

        //post
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            userService.Save(user);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,[FromBody] User user)
        {
            userService.Update(id, user);
            return Ok();
        }

        //delete
        [HttpDelete("{id}")] // aclaramos que dentro de la URL va el index para eliminar de la lista
        [Route("[action]")] //sirve para usar el nombre del metodo en la url
        public IActionResult Delete(int id) //index de la lista para eliminar
        {
            userService.Delete(id);
            return Ok();
        }

        // porque elimina esto
        private readonly ILogger<UserController> _logger;


        private UserController(ILogger<UserController> logger)
        {
            _logger = logger;

            // aca podemos hacer una lista pára manejar los datos

        }

    }
}