using FluentValidation;
using FluentValidation.Results;

namespace Shared.Core.Domain.Validators;

public abstract class BaseNoParamValidator<TVal, TDerived> : AbstractValidator<TVal>
    where TDerived : BaseNoParamValidator<TVal, TDerived>, new()
{
    public static readonly TDerived Instance = new();

    public static ValidationResult ExecuteValidation(TVal value)
        => Instance.Validate(value);
    
    public static void ExecuteValidationAndThrow(TVal value)
        => Instance.ValidateAndThrow(value);
}