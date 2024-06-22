using FluentValidation.Results;
using Shared.Core.Domain.Exceptions;

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
                    ErrorCode = failure.ErrorCode
                })
            ).ToList()
        };
    }
    
    public static ErrorResponse ToErrorResponse(string fieldName, IExcHasErrorCode exc)
    {
        return new ErrorResponse
        {
            Errors =
            [
                new KeyValuePair<string, Error>(fieldName, new Error
                {
                    Field = fieldName, ErrorCode = exc.ErrorCode
                })
            ]
        };
    }
}
