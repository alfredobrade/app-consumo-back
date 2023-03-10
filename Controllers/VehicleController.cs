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
    public class VehicleController : ControllerBase
    {
        IVehicleService vehicleService;

        public VehicleController(IVehicleService service)
        {
            vehicleService = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(vehicleService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Vehicle vehicle)
        {
            vehicleService.Save(vehicle);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Vehicle vehicle)
        {
            vehicleService.Update(id, vehicle);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            vehicleService.Delete(id);
            return Ok();
        }

        
        private readonly ILogger<VehicleController> _logger;


        private VehicleController(ILogger<VehicleController> logger)
        {
            _logger = logger;

        }

    }
}