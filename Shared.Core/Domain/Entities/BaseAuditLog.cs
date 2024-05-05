using Shared.Core.Domain.Rules.BaseEntityRules;
using Shared.Core.Domain.Validators;
using Shared.Core.Domain.ValueObjects;

namespace Shared.Core.Domain.Entities;

public abstract class BaseAuditLog
{
    public string Id { get; init; } = Guid.NewGuid().ToString();

    public required string AuthorId { get; init; }

    public required AuditType Type { get; init; }
    
    public DateTime HappenedAt { get; init; } = DateTime.Now;
}

public abstract class BaseAuditLog<TEntity> : BaseAuditLog
    where TEntity : notnull
{
    public required TEntity Entity { get; init; }
}

public class BaseAuditLogRule : BaseNoParamValidator<BaseAuditLog, BaseAuditLogRule>
{
    public BaseAuditLogRule()
    {
        RuleFor(e => e.Id)
            .SetValidator(StringIdRules.Instance);

        RuleFor(e => e.AuthorId)
            .SetValidator(StringIdRules.Instance);
        
        RuleFor(e => e.HappenedAt)
            .SetValidator(CreatedAtRule.Instance);
    }
}