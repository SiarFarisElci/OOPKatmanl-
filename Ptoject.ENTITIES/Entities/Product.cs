using Ptoject.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptoject.ENTITIES.Entities
{
    public class Product : BaseEntity , IEntity
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }

        public int? CategoryID { get; set; }

        //Relational Properties

        public virtual Category  Category { get; set; }
    }
}
