using BennerMicrowave.Domain.Validators;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BennerMicrowave.Domain.Entities
{
    public class CookProgram : ValidatableEntity<CookProgram>
    {
        public string Name { get; set; }
        public string Instructions { get; set; }
        public TimeSpan Time { get; set; }
        public int Power { get; set; }
        public char CookCharacter { get; set; }
        public IEnumerable<string> AcceptedEntries { get; set; }

        public CookProgram(string name, string instructions, TimeSpan time, int power, char cookCharacter, IEnumerable<string> acceptedEntries)
        {
            this.Name = name;
            this.Instructions = instructions;
            this.Time = time;
            this.Power = power;
            this.CookCharacter = cookCharacter;
            this.AcceptedEntries = acceptedEntries;
        }

        public bool AcceptEntry(string entry)
        {
            return AcceptedEntries.Any(c => c.ToLower().Equals(entry.ToLower()));
        }

        public override IValidator<CookProgram> Validator => new CookProgramValidator();

        public override string ToString()
        {
            return $"Programa: {Name} - {Time.TotalSeconds} segundos - Potência {Power}{Environment.NewLine}"
                + $"Entradas aceitas: {string.Join(", ", AcceptedEntries)}{Environment.NewLine}"
                + $"Instruções: {Instructions}";
        }

        public override bool Equals(object obj)
        {
            return obj is CookProgram program &&
                   this.Name == program.Name &&
                   this.Instructions == program.Instructions &&
                   this.Time.Equals(program.Time) &&
                   this.Power == program.Power &&
                   this.CookCharacter == program.CookCharacter &&
                   EqualityComparer<IEnumerable<string>>.Default.Equals(this.AcceptedEntries, program.AcceptedEntries) &&
                   EqualityComparer<IValidator<CookProgram>>.Default.Equals(this.Validator, program.Validator);
        }

        public override int GetHashCode()
        {
            var hashCode = -1398385807;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Instructions);
            hashCode = hashCode * -1521134295 + this.Time.GetHashCode();
            hashCode = hashCode * -1521134295 + this.Power.GetHashCode();
            hashCode = hashCode * -1521134295 + this.CookCharacter.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<string>>.Default.GetHashCode(this.AcceptedEntries);
            hashCode = hashCode * -1521134295 + EqualityComparer<IValidator<CookProgram>>.Default.GetHashCode(this.Validator);
            return hashCode;
        }
    }
}
