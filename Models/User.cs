using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace app_consumo.Models
{
    public class User
    {

        [Key]
        public int UserId {get; set;}
        [Required]
        public string UserName {get; set;}
        
        [JsonIgnore]
        public virtual ICollection<Vehicle> Vehicles {get; set;}

    }
}