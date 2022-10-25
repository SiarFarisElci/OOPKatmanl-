using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstrackts;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concrates
{
    public class AppUserManager : BaseManager<AppUser> , IAppUserManager
    {
        IAppUserRepository _aRep;
        public AppUserManager(IAppUserRepository aRep) : base(aRep)
        {
            _aRep = aRep;
        }
    }
}
