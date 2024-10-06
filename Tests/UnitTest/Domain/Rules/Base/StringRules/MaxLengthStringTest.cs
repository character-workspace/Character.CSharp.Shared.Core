using Shared.Core.Domain.Rules.Base.StringRules;

namespace UnitTest.Domain.Rules.Base.StringRules;

public class MaxLengthStringTest
{
    #region Unhappy

    [Fact]
    public void Validate_ShouldReturnError_WhenStringExceedsMaxLength()
    {
        #region Arrange
        
        // dependency
        var maxLength = 5;

        // input
        var stringInput = "1234567890";
        
        // target
        var targetTest = new MaxLengthString(maxLength);
        
        // expected
        var expectedErrorCount = 1;
        var expectedErrorCode = nameof(MaxLengthString);

        #endregion
        
        #region Act
        var result = targetTest.Validate(stringInput);
        #endregion

        #region Assert
        
        var errors = result.Errors;
        
        Assert.Equal(expectedErrorCount, errors.Count);
        Assert.Equal(expectedErrorCode, errors[0].ErrorCode);
        
        #endregion
    }

    #endregion

    #region Happy

    [Fact]
    public void Validate_ShouldSuccess_WhenStringEqualsMaxLength()
    {
        #region Arrange

        // dependency
        var maxLength = 5;
        
        // input
        var stringInput = "12345";
        
        // target
        var targetTest = new MaxLengthString(maxLength);
        
        // expected
        var expectedErrorCount = 0;

        #endregion
        
        #region Act
        var result = targetTest.Validate(stringInput);
        #endregion

        #region Assert
        
        var errors = result.Errors;
        
        Assert.Equal(stringInput.Length, maxLength);
        Assert.Equal(expectedErrorCount, errors.Count);
        
        #endregion
    }
    
    [Fact]
    public void Validate_ShouldSuccess_WhenStringIsEmpty()
    {
        #region Arrange
        
        // dependency
        var maxLength = 5;
        
        // input
        var stringInput = string.Empty;
        
        // target
        var targetTest = new MaxLengthString(maxLength);
        
        // expected
        var expectedErrorCount = 0;

        #endregion
        
        #region Act
        var result = targetTest.Validate(stringInput);
        #endregion

        #region Assert
        
        var errors = result.Errors;
        Assert.Equal(expectedErrorCount, errors.Count);
        
        #endregion
    }

    #endregion
}