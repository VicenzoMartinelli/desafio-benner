using BennerMicrowave.Domain.Validators;
using FluentValidation;
using System;

namespace BennerMicrowave.Domain.Entities
{
    public class CookParams : ValidatableEntity<CookParams>
    {
        public const int DefaultTimeSeconds = 30;
        public const int DefaultPower = 8;

        public int Power { get; set; }
        public TimeSpan Time { get; set; }
        public string ThingToCook { get; set; }
        public char CookChar { get; set; }
        public CookParams(int power, TimeSpan time, string thingToCook, char cookChar = '.')
        {
            this.Power = power;
            this.Time = time;
            this.ThingToCook = thingToCook;
            this.CookChar = cookChar;
        }

        public override IValidator<CookParams> Validator => new CookParamsValidator();
    }
}
