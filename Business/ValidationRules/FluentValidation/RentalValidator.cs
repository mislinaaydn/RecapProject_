using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.CustomerId).NotEmpty();
        RuleFor(c => c.RentDate).NotEmpty();
        RuleFor(c => c.RentDate).NotEmpty();

        }
    
    }
}
