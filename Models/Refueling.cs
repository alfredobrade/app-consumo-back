using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace app_consumo.Models
{
    public class Refueling
    {
        [Key]
        public int RefuelingId { get; set; }
        [Required]
        public DateTime DateTime {get; set; }
        [ForeignKey("VehicleId")]
        public int VehicleId { get; set; }
        public double Amount {get; set; }
        public double Liters { get; set; }
        public double Kilometers { get; set; }

        [JsonIgnore]
        public virtual Vehicle Vehicle { get; set; }
    }
}