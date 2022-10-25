using FluentValidation;
using Ptoject.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.FluentValidation
{
    public abstract class BaseValidation<T> : AbstractValidator<T> where T : class , IEntity
    {
        public BaseValidation()
        {

        }
    }
}
