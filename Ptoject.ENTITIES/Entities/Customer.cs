using Ptoject.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptoject.ENTITIES.Entities
{
    public class Customer : BaseEntity , IEntity
    {
        public string Name { get; set; }
        
        public string Ctiy { get; set; }
        public int?  JobID { get; set; }
        //Relational Properties

        public virtual Job  Job { get; set; }
    }
}
