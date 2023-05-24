using FluentValidation;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.ValidationRules.FluentValidation
{
    public class FactoryValidator : AbstractValidator<Factory>
    {
        public FactoryValidator()
        {
            RuleFor(f => f.CompanyName).NotEmpty().WithMessage("Company name cannot be empty!");
            RuleFor(f => f.CompanyName).MinimumLength(3).WithMessage("Factory name must be at least 3 characters long");
            RuleFor(f => f.Adress).NotEmpty().WithMessage("Adress cannot be empty!");
            RuleFor(f => f.City).NotEmpty().WithMessage("City cannot be empty!");
            RuleFor(f => f.Country).NotEmpty().WithMessage("Country cannot be empty!");
            RuleFor(f => f.Phone).NotEmpty().WithMessage("Phone cannot be empty!");
            RuleFor(f => f.Phone).MinimumLength(5).WithMessage("Phone must be at least 5 characters long");
            RuleFor(f => f.ContactName).NotEmpty().WithMessage("Contact name cannot be empty!");
            RuleFor(f => f.ContactTitle).NotEmpty().WithMessage("Contact title cannot be empty!");     
            RuleFor(f => f.Password).NotEmpty().WithMessage("Password cannot be empty!");
            RuleFor(f => f.Password).MinimumLength(5).WithMessage("Password must be at least 4 characters long");
            RuleFor(f => f.Password).MaximumLength(28).WithMessage("Password must be at most 28 characters long");
            RuleFor(f => f.Password).Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{4,28}$")
                .WithMessage("Password must contain at least one uppercase letter, one lowercase letter, one number and one special character");
            RuleFor(f => f.HomePage).NotEmpty().WithMessage("Home page cannot be empty!");
            
        }
    }
}
