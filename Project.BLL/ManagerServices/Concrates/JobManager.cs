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
    public class JobManager : BaseManager<Job> , IJobManager
    {
        IJobRepository _jRep;

        public JobManager(IJobRepository jRep) : base(jRep)
        {
            _jRep = jRep;
        }
    }
}
