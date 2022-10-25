using Project.DAL.Context;
using Project.DAL.Repositories.Abstrackts;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concrates
{
    public class JobRepository : BaseRepository<Job> , IJobRepository
    {
        public JobRepository(MyContext db) : base(db)
        {

        }
    }
}
