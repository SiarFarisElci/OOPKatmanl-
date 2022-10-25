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
    public class AppRoleManager : BaseManager<AppRole> , IAppRoleManager
    {
        IAppRoleRepository _apRep;

        public AppRoleManager(IAppRoleRepository apRep) : base(apRep)
        {
            _apRep = apRep;
        }
    }
}
