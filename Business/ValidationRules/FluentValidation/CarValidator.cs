﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator : AbstractValidator<Car>
    {

        public CarValidator()
        {
            RuleFor(c =>c.Description).MinimumLength(2).WithMessage("Araç İsmi Minumum 2 Karakterli Olmalıdır.");
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
        }

    }
}
