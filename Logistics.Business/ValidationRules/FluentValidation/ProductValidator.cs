using FluentValidation;
using Logistics.Entities.Concrete;
using System.Data;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        //fluent validation 
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name cannot be empty!");
            RuleFor(p => p.ProductName).MinimumLength(2);
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(10000).When(p => p.CategoryID == 2).WithMessage("Price must be greater than 10 for category 2");
            RuleFor(p => p.UnitInStock).NotEmpty();
            RuleFor(p => p.UnitInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.ProductID).GreaterThan(0);
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Product name must start with A");

        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
