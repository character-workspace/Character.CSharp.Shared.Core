using Shared.Core.Domain.Rules.BaseEntityRules;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Entities;

public abstract class BaseEntity
{
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public DateTime CreatedAt { get; init; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; } = default;
}

public class BaseEntityRule : BaseNoParamValidator<BaseEntity, BaseEntityRule>
{
    public BaseEntityRule()
    {
        RuleFor(e => e.Id)
            .SetValidator(StringIdRules.Instance);

        RuleFor(e => e.CreatedAt)
            .SetValidator(CreatedAtRule.Instance);
    }
}