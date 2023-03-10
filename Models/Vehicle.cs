using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace app_consumo.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string VehicleName { get; set; }
        public int VehicleType { get; set; } //1 auto, 2 moto 
        public double TankCapacity { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        //propiedades de navegacion .. investigar
        [JsonIgnore]
        public virtual User User { get; set; }

        [JsonIgnore]
        public virtual ICollection<Refueling> Refuelings { get; set; }
        
    }
}