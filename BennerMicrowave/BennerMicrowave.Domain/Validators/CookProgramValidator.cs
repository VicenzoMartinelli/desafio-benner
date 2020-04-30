using BennerMicrowave.Domain.Entities;
using BennerMicrowave.Domain.Extensions;
using FluentValidation;
using System.Linq;

namespace BennerMicrowave.Domain.Validators
{
    public class CookProgramValidator : AbstractValidator<CookProgram>
    {
        public CookProgramValidator()
        {
            RuleFor(p => p.Time).ValidCookTime();

            RuleFor(p => p.Power).ValidCookPower();

            RuleFor(p => p.CookCharacter)
                .NotEmpty()
                .WithMessage("Preencha o caracter de cozimento");

            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Preencha o nome do programa");

            RuleFor(p => p.AcceptedEntries)
                .Must(p => p.Any())
                .WithMessage("Informe ao menos uma entrada");

        }
    }
}
