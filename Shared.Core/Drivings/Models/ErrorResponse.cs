using FluentValidation.Results;

namespace Shared.Core.Drivings.Models;

public class ErrorResponse
{
    public required List<KeyValuePair<string, Error>> Errors { get; set; }

    public static ErrorResponse ToErrorResponse(ValidationResult validationResult)
    {
        return new ErrorResponse
        {
            Errors = validationResult.Errors.Select(failure 
                => new KeyValuePair<string, Error>(failure.PropertyName, new Error
                {
                    Field = failure.PropertyName,
                    AttemptData = failure.AttemptedValue,
                    ErrorCode = failure.ErrorCode
                })
            ).ToList()
        };
    }
}
