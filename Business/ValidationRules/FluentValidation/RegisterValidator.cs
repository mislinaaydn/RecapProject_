using Business.Constans;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public class RegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public RegisterValidator()
        {
            RuleFor(u => u.FirstName.Length).GreaterThanOrEqualTo(3).WithMessage(Messages.NameInvalid);
            RuleFor(u => u.LastName.Length).GreaterThanOrEqualTo(2).WithMessage(Messages.SurnameInvalid);
            RuleFor(u => u.Password.Length).GreaterThanOrEqualTo(5).WithMessage(Messages.PasswordInvalid);
            RuleFor(u => u.Email).Must(Email).WithMessage(Messages.EmailInvalid);
        }

        private bool Email(string arg)
        {
            throw new NotImplementedException();
        }
    }
}
