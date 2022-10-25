using FluentValidation;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.FluentValidation
{
    public class CustomerValidator : BaseValidation<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x=> x.Name).NotEmpty().WithMessage("Isım bos gecilemez");
            RuleFor(x=> x.Ctiy).NotEmpty().WithMessage("Sehir bos gecilemez");
        }
    }
}
