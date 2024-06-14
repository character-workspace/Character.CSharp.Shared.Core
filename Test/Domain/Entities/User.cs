using Shared.Core.Domain.Entities;
using Shared.Core.Domain.Validators;

namespace Test.Domain.Entities;

public class User : BaseEntity
{
    
}

public class UserRule : BaseNoParamValidator<User, UserRule>
{
    public UserRule()
    {
    }
}