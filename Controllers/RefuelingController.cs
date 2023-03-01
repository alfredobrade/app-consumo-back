using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace app_consumo.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RefuelingController : ControllerBase
    {
        private readonly ILogger<RefuelingController> _logger;


        private RefuelingController(ILogger<RefuelingController> logger)
        {
            _logger = logger;

            

        }





    }
}