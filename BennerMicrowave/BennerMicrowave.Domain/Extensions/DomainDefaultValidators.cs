using FluentValidation;
using System;

namespace BennerMicrowave.Domain.Extensions
{
    public static class DomainDefaultValidators
    {
        public static IRuleBuilderOptions<T, int> ValidCookPower<T>(this IRuleBuilder<T, int> ruleBuilder)
        {
            var minPower = 1;
            var maxPower = 10;

            return ruleBuilder
                .InclusiveBetween(minPower, maxPower)
                .WithMessage("O tempo deve estar entre 1 e 10");
        }

        public static IRuleBuilderOptions<T, TimeSpan> ValidCookTime<T>(this IRuleBuilder<T, TimeSpan> ruleBuilder)
        {
            var minTime = new TimeSpan(0, 0, 1);
            var maxTime = new TimeSpan(0, 2, 0);

            return ruleBuilder
                .InclusiveBetween(minTime, maxTime)
                .WithMessage("O tempo deve estar entre 1 segundo e 2 minutos");
        }
    }
}
