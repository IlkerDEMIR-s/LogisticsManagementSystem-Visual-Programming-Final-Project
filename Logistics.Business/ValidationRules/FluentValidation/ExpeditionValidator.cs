using FluentValidation;
using Logistics.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics.Business.ValidationRules.FluentValidation
{
    public class ExpeditionValidator : AbstractValidator<Expedition>
    {
        public ExpeditionValidator()
        {
            RuleFor(e => e.CargoName).NotEmpty().WithMessage("Cargo name cannot be empty!");
            RuleFor(e => e.CargoName).MinimumLength(6).WithMessage("Cargo name must be at least 6 characters long");
            RuleFor(e => e.CargoName).MaximumLength(50).WithMessage("Cargo name must be maximum 50 characters long");
            RuleFor(e => e.CargoParcelAmount).NotEmpty().WithMessage("Cargo parcel amount cannot be empty!");
            RuleFor(e => e.CargoParcelAmount).GreaterThanOrEqualTo(0)
                                           .WithMessage("Cargo parcel amount must be greater than or equal to 0");
            RuleFor(e => e.CargoParcelAmount).LessThanOrEqualTo(500);
            RuleFor(e => e.TotalCargoVolume).NotEmpty().WithMessage("Total cargo volume cannot be empty!");
            RuleFor(e => e.TotalCargoVolume).GreaterThanOrEqualTo(1)
                                           .WithMessage("Total cargo volume must be greater than or equal to 1");
            RuleFor(e => e.TotalCargoWeight).NotEmpty().WithMessage("Total cargo weight cannot be empty!");
            RuleFor(e => e.TotalCargoWeight).GreaterThanOrEqualTo(1)
                                           .WithMessage("Total cargo weight must be greater than or equal to 1");
            RuleFor(e => e.EstimatedArrivalDate).NotEmpty().WithMessage("Estimated arrival date cannot be empty!");
            RuleFor(e => e.EstimatedArrivalDate).GreaterThanOrEqualTo(DateTime.Now.Date)
                                           .WithMessage("Estimated arrival date must be greater than or equal to today");
            RuleFor(e => e.EstimatedDepartureDate).NotEmpty().WithMessage("Estimated departure date cannot be empty!");
            RuleFor(e => e.EstimatedDepartureDate).GreaterThanOrEqualTo(DateTime.Now.Date)
                                           .WithMessage("Estimated departure date must be greater than or equal to today");
            RuleFor(e => e.EstimatedDepartureDate).LessThanOrEqualTo(e => e.EstimatedArrivalDate)
                                             .WithMessage("Estimated departure date must be less than or equal to estimated arrival date");
            //RuleFor(e => e.ActualArrivalDate).NotEmpty().WithMessage("Actual arrival date cannot be empty!");
            //RuleFor(e => e.ActualArrivalDate).GreaterThanOrEqualTo(DateTime.Now)
            //                               .WithMessage("Actual arrival date must be greater than or equal to today");
            //RuleFor(e => e.ActualDepartureDate).NotEmpty().WithMessage("Actual departure date cannot be empty!");
            //RuleFor(e => e.ActualDepartureDate).GreaterThanOrEqualTo(DateTime.Now)
            //                               .WithMessage("Actual departure date must be greater than or equal to today");
            //RuleFor(e => e.ActualDepartureDate).LessThanOrEqualTo(e => e.ActualArrivalDate)
            //                                 .WithMessage("Actual departure date must be less than or equal to actual arrival date");
            //RuleFor(e => e.CargoStatusName).NotEmpty().WithMessage("Cargo status cannot be empty!");

        }
    }
}           
