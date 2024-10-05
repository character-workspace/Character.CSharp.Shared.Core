using Shared.Core.Domain.Errors.Base;
using Shared.Core.Domain.Rules.Base.GuidRules;

namespace UnitTest.Domain.Rules.Base.GuidRules;

public class RequiredGuidTest
{
    #region Unhappy

    [Fact]
    public void Validate_ShouldReturnError_WhenGuidIsEmpty()
    {
        #region Arrange
        
        // input
        var guidInput = Guid.Empty;

        // target
        var targetTest = new RequiredGuid();
        
        // expected
        var expectedErrorCode = CommonErrors.Required;
        var expectedErrorCount = 1;

        #endregion

        #region Act
        var result = targetTest.Validate(guidInput);
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
    public void Validate_ShouldSuccess_WhenGuidIsValid()
    {
        #region Arrange
    
        // mock
        
        // input
        var guidInput = Guid.NewGuid();
        
        // target
        var targetTest = new RequiredGuid();
        
        // expected
        var expectedErrorCount = 0;
        
        #endregion
    
        #region Act
        var result = targetTest.Validate(guidInput);
        #endregion
    
        #region Assert
        
        var errors = result.Errors;
        Assert.Equal(expectedErrorCount, errors.Count);
        
        #endregion
    }

    #endregion
}