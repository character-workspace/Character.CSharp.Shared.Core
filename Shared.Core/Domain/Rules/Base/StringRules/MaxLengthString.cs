using FluentValidation;

namespace Shared.Core.Domain.Rules.Base.StringRules;

public class MaxLengthString : AbstractValidator<string>
{
    public MaxLengthString(int maxLength)
    {
        RuleFor(s => s)
            .MaximumLength(maxLength)   
            .WithErrorCode(nameof(MaxLengthString));
    }
}