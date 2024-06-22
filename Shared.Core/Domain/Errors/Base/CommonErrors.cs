namespace Shared.Core.Domain.Errors.Base;

public static class CommonErrors
{
    public const string Required = nameof(Required);
    
    public const string ExceedMaxValue = nameof(ExceedMaxValue);
    public const string NotReachMinValue = nameof(NotReachMinValue);
    
    public const string AlreadyTaken = nameof(AlreadyTaken);
}