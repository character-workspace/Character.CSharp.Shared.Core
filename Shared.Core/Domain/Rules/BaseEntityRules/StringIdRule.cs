using Shared.Core.Domain.Rules.Base.StringRules;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.BaseEntityRules;

public class StringIdRules : BaseNoParamValidator<string, StringIdRules>
{
    private static readonly RequiredString RequiredString = new();
    
    public StringIdRules()
    {
        RuleFor(id => id)
            .SetValidator(RequiredString);
    }
}