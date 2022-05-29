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
            RuleFor(car => car.CarId).NotEmpty();
            RuleFor(car => car.ColorId).NotEmpty();
            RuleFor(car => car.BrandId).NotEmpty();

            RuleFor(car => car.ModelYear).NotEmpty();
            RuleFor(car => car.ModelYear).InclusiveBetween(2000, DateTime.Now.Year);

            RuleFor(car => car.DailyPrice).NotEmpty();
            RuleFor(car => car.DailyPrice).GreaterThanOrEqualTo(1);

            RuleFor(car => car.Description).NotEmpty();
            RuleFor(car => car.Description).MinimumLength(10);
            RuleFor(car => car.Description).MaximumLength(500);

        }
    }
}
