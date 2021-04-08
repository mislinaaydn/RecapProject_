using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("fiyat");
            RuleFor(c => c.Description).NotEmpty().WithMessage("aciklama");
            RuleFor(c => c.ModelName).NotNull().WithMessage("model adi");
            RuleFor(c => c.ModelYear).NotEmpty().WithMessage("model yili");
           


        }
    }
}

