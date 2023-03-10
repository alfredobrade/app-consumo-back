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
    public class RefuelingController : ControllerBase
    {
        //recibimos el servicio con toda la logica del modelo
        IRefuelingService refuelingService;

        public RefuelingController(IRefuelingService service)
        {
            refuelingService = service;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(refuelingService.Get());
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Refueling refueling)
        {
            refuelingService.Save(refueling); 
            return Ok();
        }

        [HttpPut("{id}")]//los datos vienen de la url por lo que se aclara que de alli viene un id
        public IActionResult Put(int id, [FromBody] Refueling refueling)
        {
            refuelingService.Update(id, refueling);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            refuelingService.Delete(id);
            return Ok();
        }





        private readonly ILogger<RefuelingController> _logger;


        private RefuelingController(ILogger<RefuelingController> logger)
        {
            _logger = logger;

        }





    }
}