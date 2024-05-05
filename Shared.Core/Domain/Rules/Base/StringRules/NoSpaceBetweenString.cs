using FluentValidation;
using Shared.Core.Domain.Errors.Base;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.Base.StringRules;

public class NoSpaceBetweenString : BaseNoParamValidator<string, NoSpaceBetweenString>
{
    public NoSpaceBetweenString()
    {
        RuleFor(s => s)
            .Must(s => !s.Trim().Contains(' '))
            .WithErrorCode(StringErrors.NoSpaceBetween);
    }
}