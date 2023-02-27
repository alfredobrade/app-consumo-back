using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_consumo.Models
{
    public class User
    {
        private int UserId {get; set;}
        private string UserName {get; set;}
        
        public IEnumerable<Vehicle> Vehicles {get; set;}

    }
}