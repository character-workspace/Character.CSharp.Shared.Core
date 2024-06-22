namespace Shared.Core.Domain.Errors.Base;

public static class StringErrors
{
    public const string ExceedMaxLength = nameof(ExceedMaxLength);
    public const string NotReachMinLength = nameof(NotReachMinLength);
    
    public const string ShouldHaveNoSpaceAround = nameof(ShouldHaveNoSpaceAround);
    public const string ShouldHaveNoSpaceBetween = nameof(ShouldHaveNoSpaceBetween);
    public const string ShouldHaveNoSpace = nameof(ShouldHaveNoSpace);
}