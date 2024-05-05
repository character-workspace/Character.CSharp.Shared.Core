namespace Shared.Core.Domain.Errors.Base;

public static class StringErrors
{
    public const string ExceedMaxLength = nameof(ExceedMaxLength);
    public const string NotReachMinLength = nameof(NotReachMinLength);
    
    public const string NoSpaceAround = nameof(NoSpaceAround);
    public const string NoSpaceBetween = nameof(NoSpaceBetween);
    public const string NoSpace = nameof(NoSpace);
}