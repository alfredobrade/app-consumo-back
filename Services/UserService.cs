using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Context;
using app_consumo.Models;
using app_consumo.ServiceInterfaces;

namespace app_consumo.Services
{
    public class UserService : IUserService
    {
        readonly ConsumosContext dbcontext;

        public UserService(ConsumosContext context)
        {
            dbcontext = context;
        }

        public async Task Delete(int id)
        {
            var actualUser = dbcontext.Users.Find(id);

            if(actualUser != null)
            {
                dbcontext.Remove(actualUser);
                await dbcontext.SaveChangesAsync();
            }
        }

        public IEnumerable<User> Get()
        {
            return dbcontext.Users;
        }

        public void Save(User user)
        {
            dbcontext.Add(user);
            dbcontext.SaveChangesAsync();

        }

        public async Task Update(int id, User user)
        {
            var actualUser = dbcontext.Users.Find(id);

            if(actualUser != null)
            {
                //actualUser.UserId = user.UserId;  no me deja porque las properties son private en ESTA entidad


                await dbcontext.SaveChangesAsync();
            }
        }
    }
}