using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app_consumo.Models;

namespace app_consumo.ServiceInterfaces
{
    public interface IUserService
    {
        public IEnumerable<User> Get();
        public void Save(User user);
        Task Update(int id, User user);
        Task Delete(int id);
    }
}