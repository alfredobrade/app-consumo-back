using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Context;
using app_consumo.Models;
using app_consumo.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace app_consumo.Services
{
    public class VehicleService : IVehicleService
    {
        readonly ConsumosContext dbcontext;

        public VehicleService(ConsumosContext context)
        {
            dbcontext = context;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vehicle> Get()
        {
            throw new NotImplementedException();
        }

        public void Save(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Vehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}