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
    public class CustomerManager : BaseManager<Customer>, ICustomerManager
    {
        ICustomerRepository _cRep;
        public CustomerManager(ICustomerRepository cRep) : base(cRep)
        {
            _cRep = cRep;
        }

    }
}
