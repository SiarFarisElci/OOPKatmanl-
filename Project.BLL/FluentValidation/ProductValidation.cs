using FluentValidation;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.FluentValidation
{
    public class ProductValidation : BaseValidation<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Urun Adı bos gecilemez");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok sayısı bos gecilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat  bos gecilemez");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Urun Adı en az 3 karakter olmalıdır");
           
        }
    }
}
