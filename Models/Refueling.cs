using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_consumo.Models
{
    public class Refueling
    {
        public int RefuelingId { get; set; }
        public int VehicleId { get; set; }
        public double Amount {get; set; }
        public double Liters { get; set; }
        public double Kilometers { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}