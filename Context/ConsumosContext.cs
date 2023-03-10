using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Models;
using Microsoft.EntityFrameworkCore;

namespace app_consumo.Context
{
    public class ConsumosContext : DbContext
    {
        public DbSet<User> Users {get; set;}
        public DbSet<Vehicle> Vehicles {get; set;}
        public DbSet<Refueling> Refuelings {get; set;}

        //metodo base del constructor de EF
        public ConsumosContext(DbContextOptions<ConsumosContext> options) : base(options) {}


        // aca podemos empezar a configurar fluentAPI
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        */
        //puede ser necesario importar Microsoft.EntityFrameworkCore.Relational

    }
}