using Ptoject.ENTITIES.Entities;
using System.Collections.Generic;

namespace Project.COREUI.ViemClasses
{
    public class ProductVM
    {
        public Product  Product { get; set; }
        public Category  Category  { get; set; }
        public List<Product>  Products { get; set; }
        public List<Category>  Categories  { get; set; }
    }
}
