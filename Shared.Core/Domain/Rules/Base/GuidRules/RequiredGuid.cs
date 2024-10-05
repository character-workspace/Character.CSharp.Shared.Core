using FluentValidation;
using Shared.Core.Domain.Errors.Base;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.Base.GuidRules;

public class RequiredGuid : BaseNoParamValidator<Guid, RequiredGuid>
{
    public RequiredGuid()
    {
        RuleFor(g => g)
            .NotEqual(Guid.Empty)
            .WithErrorCode(CommonErrors.Required);
    }
}