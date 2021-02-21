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
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MaximumLength(15);
            RuleFor(c => c.Description).MinimumLength(0);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(100).When(c=>c.CarId==34);
            RuleFor(c => c.CarName).Must(StartWithM).WithMessage("M harfi ile başlamalı");
        }

        private bool StartWithM(string arg)
        {
            return arg.StartsWith("M");
        }
    }
    

    }

