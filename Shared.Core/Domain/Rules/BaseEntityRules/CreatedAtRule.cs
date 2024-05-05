using FluentValidation;
using Shared.Core.Domain.Errors.Base;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.BaseEntityRules;

public class CreatedAtRule : BaseNoParamValidator<DateTime, CreatedAtRule>
{
    public CreatedAtRule()
    {
        RuleFor(c => c)
            .LessThanOrEqualTo(_ => DateTime.Now)
            .WithErrorCode(CommonErrors.ExceedMaxValue);
    }
}