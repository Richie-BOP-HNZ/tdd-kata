using System.IO.Pipelines;

namespace TddKata1.UnitTests;

public class StringCalculator
{
    [Fact]
    public void StringCalculatorEmptyStringReturnsZero()
    {
        // Arrange
        var program = new TddKata1.Program();

        // Act
        var result = program.Add("");

        // Assert
        Assert.True(result.Equals(0));
    }
}
