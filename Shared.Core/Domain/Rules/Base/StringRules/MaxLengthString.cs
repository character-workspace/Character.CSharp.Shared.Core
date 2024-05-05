using FluentValidation;
using Shared.Core.Domain.Errors.Base;

namespace Shared.Core.Domain.Rules.Base.StringRules;

public class MaxLengthString : AbstractValidator<string>
{
    public MaxLengthString(int maxLength)
    {
        RuleFor(s => s)
            .MaximumLength(maxLength)
            .WithErrorCode(nameof(StringErrors.ExceedMaxLength));
    }
}