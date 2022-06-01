using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(carImage => carImage.ImageId).NotEmpty();
            RuleFor(carImage => carImage.CarId).NotEmpty();
            RuleFor(carImage => carImage.ImagePath).NotEmpty();
        }
    }
}
