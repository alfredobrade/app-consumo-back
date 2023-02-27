using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_consumo.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set;}
        public string VehicleName { get; set;}
        public int VehicleType { get; set;}
        public double TankCapacity { get; set;}
        public int UserId { get; set;}

        public virtual User User { get; set;}
        public IEnumerable<Refueling> Refuelings { get; set;}
        
    }
}