using FluentValidation;
using Shared.Core.Domain.Errors.Base;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.Base.StringRules;

public class NoSpaceAroundString : BaseNoParamValidator<string, NoSpaceAroundString>
{
    public NoSpaceAroundString()
    {
        RuleFor(s => s)
            .Must(s => !(s.StartsWith(' ') || s.EndsWith(' ')))
            .WithErrorCode(StringErrors.NoSpaceAround);
    }
}