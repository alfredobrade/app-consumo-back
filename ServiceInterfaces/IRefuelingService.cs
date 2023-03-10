using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Models;
using app_consumo.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace app_consumo.ServiceInterfaces
{
    public interface IRefuelingService
    
        //<T> : where T : class   para definir una interfaz generica
    {
        // estos 4 metodos pueden ir en una interfaz IBasicCRUD
        // aunque el problema es que cambian los parámetros
        /* se podria poner la entidad dentro de un objeto estandar
        y luego pasar como parametro a ese objeto?
        */
        IEnumerable<Refueling> Get();
        Task Save(Refueling refueling);
        Task Update(int id, Refueling refueling);
        Task Delete(int id);
        
    }
}