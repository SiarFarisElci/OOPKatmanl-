using FluentValidation;
using Ptoject.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.FluentValidation
{
    public class CategoryValidator : BaseValidation<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=> x.CategoryName).NotEmpty().WithMessage("Category adı bos geçilemez");
        }
    }
}
