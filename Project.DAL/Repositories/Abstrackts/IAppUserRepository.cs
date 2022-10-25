using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Abstrackts
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        //Task<bool> AddUser(AppUser item);
    }
}
