using MathDemo.Core;

namespace MathDemo.UnitTests;

public class ArithmeticProgressionTests
{
    [Theory]
    [InlineData(2,2,7)]
    [InlineData(5,2,5)]
    public void GetTerm_ReturnsCorrectValue(int firstTerm, int commonDifference, int n)
    {
        // Arrange
        var expectedTermValue =  firstTerm + (n - 1) * commonDifference;
        var arithmeticProgression = new ArithmeticProgression
        {
            FirstTerm = firstTerm,
            CommonDifference = commonDifference,
        };
        // Act
        var result = arithmeticProgression.GetTerm(n);
        
        // Assert
        Assert.Equal(expectedTermValue, result);
    }
}
