using FluentValidation;
using Shared.Core.Domain.Errors.Base;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.Base.StringRules;

public class NoSpaceString : BaseNoParamValidator<string, NoSpaceString>
{
    public NoSpaceString()
    {
        RuleFor(s => s)
            .Must(s => !s.Contains(' '))
            .WithErrorCode(StringErrors.ShouldHaveNoSpace);
    }
}