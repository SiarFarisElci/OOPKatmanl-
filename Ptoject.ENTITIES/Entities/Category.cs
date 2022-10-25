using Ptoject.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptoject.ENTITIES.Entities
{
    public class Category : BaseEntity , IEntity
    {
        public string CategoryName { get; set; }

        //Relational Properties

        public virtual List<Product>  Products { get; set; }
    }
}
