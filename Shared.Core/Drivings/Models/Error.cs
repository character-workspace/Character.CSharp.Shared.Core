namespace Shared.Core.Drivings.Models;

public class Error
{
    public required string Field { get; init; }
    public required string ErrorCode { get; init; }
}