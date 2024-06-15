using Shared.Core.Domain.Rules.Base.StringRules;
using Shared.Core.Domain.Validators;

namespace Shared.Core.Domain.Rules.BaseEntityRules;

public class StringIdRule : BaseNoParamValidator<string, StringIdRule>
{
    // TODO maybe we need a common to store the 255 value
    public const int MaxLen = 255;
    // TODO should we have it?
    private const int MinLen = 10;
    
    private static readonly MaxLengthString MaxLengthString = new (MaxLen);
    private static readonly MinLengthString MinLengthString = new (MinLen);
    
    public StringIdRule()
    {
        RuleFor(id => id)
            .SetValidator(RequiredString.Instance)
            .SetValidator(MinLengthString)
            .SetValidator(MaxLengthString);
    }
}