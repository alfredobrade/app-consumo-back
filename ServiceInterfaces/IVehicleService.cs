using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Models;

namespace app_consumo.ServiceInterfaces
{
    public interface IVehicleService
    {
        public IEnumerable<Vehicle> Get();
        public void Save(Vehicle vehicle);
        Task Update(int id, Vehicle vehicle);
        Task Delete(int id);
    }
}