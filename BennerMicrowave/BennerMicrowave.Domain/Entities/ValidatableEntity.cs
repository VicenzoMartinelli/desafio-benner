using FluentValidation;
using System.Linq;

namespace BennerMicrowave.Domain.Entities
{
    public abstract class ValidatableEntity<T>
        where T : ValidatableEntity<T>
    {
        public abstract IValidator<T> Validator { get; }

        public bool IsValid => Validator?.Validate((T)this).IsValid ?? true;

        public string ValidationMessage => string.Join("\n", Validator?.Validate((T)this).Errors.Select(c => c.ErrorMessage));
    }
}
