using FluentValidation;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.ValidationRules.FluentValidation
{
    public class DepotValidator : AbstractValidator<Depot>
    {
        //fluent validation 
        public DepotValidator()
        {
            RuleFor(d => d.DepotName).NotEmpty().WithMessage("Depot name cannot be empty!");
            RuleFor(d => d.DepotName).MinimumLength(6).WithMessage("Depot name must be at least 6 characters long");
            RuleFor(d => d.Address).NotEmpty().WithMessage("Adress cannot be empty!");
            RuleFor(d => d.City).NotEmpty().WithMessage("City cannot be empty!");
            RuleFor(d => d.Country).NotEmpty().WithMessage("Country cannot be empty!");
            RuleFor(d => d.Phone).NotEmpty().WithMessage("Phone cannot be empty!");
            RuleFor(d => d.Phone).MinimumLength(5).WithMessage("Phone must be at least 5 characters long");
            RuleFor(d => d.UnitInStock).NotEmpty().WithMessage("Unit in stock cannot be empty!");
            RuleFor(d => d.UnitInStock).GreaterThanOrEqualTo(0)
                                           .WithMessage("Unit in stock must be greater than or equal to 0");
            RuleFor(d => d.ContactName).NotEmpty().WithMessage("Contact name cannot be empty!");
            RuleFor(d => d.ContactTitle).NotEmpty().WithMessage("Contact title cannot be empty!");
            RuleFor(d => d.ProductID).NotEmpty().WithMessage("Product ID cannot be empty!");


        }
    }
}
