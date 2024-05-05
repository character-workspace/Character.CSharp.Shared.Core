using Shared.Core.Domain.Rules.Base.GuidRules;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.BaseEntityRules;

public class GuidIdRule : BaseNoParamValidator<Guid, GuidIdRule>
{
    private static readonly RequiredGuid RequiredGuid = new();
    
    public GuidIdRule()
    {
        RuleFor(id => id)
            .SetValidator(RequiredGuid);
    }
}