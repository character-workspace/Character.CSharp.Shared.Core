using Shared.Core.Domain.Rules.BaseEntityRules;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Entities;

public abstract class BaseEntity
{
    // NOTE Please ensure that you pass a unique value when doing so manually (init). We are working on a better solution for this process in the future.
    public string Id { get; init; } = Guid.NewGuid().ToString();
    public DateTime CreatedAt { get; init; } = DateTime.Now;
    public DateTime? LastUpdatedAt { get; set; } = default;
}

public class BaseEntityRule : BaseNoParamValidator<BaseEntity, BaseEntityRule>
{
    public BaseEntityRule()
    {
        RuleFor(e => e.Id)
            .SetValidator(StringIdRule.Instance);

        // TODO maybe we don't need this
        // RuleFor(e => e.CreatedAt)
        //     .SetValidator(CreatedAtRule.Instance);
    }
}