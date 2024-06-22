using FluentValidation;
using Shared.Core.Domain.Errors.Base;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.Base.StringRules;

public class RequiredString : BaseNoParamValidator<string, RequiredString>
{
    public RequiredString()
    {
        RuleFor(s => s)
            .NotNull()
            .WithErrorCode(nameof(CommonErrors.Required))
            .NotEmpty()
            .WithErrorCode(nameof(CommonErrors.Required));
    }
}