using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Services;
using Microsoft.AspNetCore.Mvc;

namespace app_consumo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        //inyectamos la dependencia
        IHelloWorldService helloWorldService;
        
        //contructor de la clase, le pasamos la dependencia como parametro
        public HelloWorldController(IHelloWorldService helloWorld)
        {
            helloWorldService = helloWorld;
        }

        //aca ya podemos usar la dependencia inyectada
        public IActionResult get()
        {
            return Ok(helloWorldService.GetHelloWorld());
        }
    }
}