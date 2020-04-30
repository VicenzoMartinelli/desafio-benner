using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Extensions;
using FluentValidation;

namespace BennerMicrowave.Domain.Validators
{
    public class CookParamsValidator : AbstractValidator<CookParams>
    {
        public CookParamsValidator()
        {
            RuleFor(p => p.Time).ValidCookTime();

            RuleFor(p => p.Power).ValidCookPower();

            RuleFor(p => p.ThingToCook)
                .NotEmpty()
                .WithMessage("O objeto de cozimento é obrigatório");
        }
    }
}
