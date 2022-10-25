using Ptoject.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptoject.ENTITIES.Entities
{
    public class Job : BaseEntity , IEntity
    {
        public string Name { get; set; }

        //Relational Properties

        public virtual List<Customer> Customers { get; set; }
    }
}
