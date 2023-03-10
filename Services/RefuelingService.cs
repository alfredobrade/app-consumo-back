using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Models;
using app_consumo.ServiceInterfaces;
using app_consumo.Context;

namespace app_consumo.Services
{
    public class RefuelingService : IRefuelingService
    {
        //inyectamos la dependencia de dbcontext
        readonly ConsumosContext dbcontext; //por que me pidio que sea readonly

        public RefuelingService(ConsumosContext context)
        {
            dbcontext = context;
        }

        public IEnumerable<Refueling> Get()
        {
            return dbcontext.Refuelings;
        }
        /* este lo sacamos para hacerlo asincrono
        public void Save(Refueling refueling)
        {
            dbcontext.Add(refueling);
            dbcontext.SaveChanges();
        }
        */
        public async Task Save(Refueling refueling)
        {
            dbcontext.Add(refueling);
            await dbcontext.SaveChangesAsync();

        }

        public async Task Update(int id, Refueling refueling)// podria hacer un overload para que uno se por id y el otro por objeto
        {

            var actualRefueling = dbcontext.Refuelings.Find(refueling.RefuelingId); //aca estoy extrayendo el id del objeto 

            if (actualRefueling != null)
            {
                actualRefueling.DateTime = refueling.DateTime;
                actualRefueling.VehicleId = refueling.VehicleId;
                actualRefueling.Kilometers = refueling.Kilometers;
                actualRefueling.Liters = refueling.Liters;
                actualRefueling.Amount = refueling.Amount;

                await dbcontext.SaveChangesAsync();

            }
            
        }
        public async Task Delete( int id)
        {
            var actualRefueling = dbcontext.Refuelings.Find(id);

            if (actualRefueling != null)
            {
                dbcontext.Remove(actualRefueling);

                await dbcontext.SaveChangesAsync();

            }
            
        }



    }
}