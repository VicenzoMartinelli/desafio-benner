using BennerMicrowave.Domain.Entities;
using FluentValidation;
using System;

namespace BennerMicrowave.Domain.Validators
{
    public class CookParamsValidator : AbstractValidator<CookParams>
    {
        public CookParamsValidator()
        {
            var minTime = new TimeSpan(0, 0, 1);
            var maxTime = new TimeSpan(0, 2, 0);

            RuleFor(p => p.Time)
                .InclusiveBetween(minTime, maxTime)
                .WithMessage("O tempo deve estar entre 1 segundo e 2 minutos");

            var minPower = 1;
            var maxPower = 10;
            RuleFor(p => p.Power)
                .InclusiveBetween(minPower, maxPower)
                .WithMessage("O tempo deve estar entre 1 e 10");

            RuleFor(p => p.ThingToCook)
                .NotEmpty()
                .WithMessage("O objeto de cozimento é obrigatório");
        }
    }
}
