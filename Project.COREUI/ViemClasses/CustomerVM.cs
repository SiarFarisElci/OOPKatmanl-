using Ptoject.ENTITIES.Entities;
using System.Collections.Generic;

namespace Project.COREUI.ViemClasses
{
    public class CustomerVM
    {
        public Customer  Customer { get; set; }
        public Job  Job { get; set; }
        public List<Customer>  Customers { get; set; }
        public List<Job>   Jobs { get; set; }
    }
}
