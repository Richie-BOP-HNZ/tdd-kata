namespace TddKata1.UnitTests;

public class StringCalculatorTests
{
    [Fact]
    public void StringCalculatorEmptyStringReturnsZero()
    {
        // Arrange
        
        // Act
        var result = StringCalculator.Add("");

        // Assert
        Assert.True(result.Equals(0));
    }

    [Fact]
    public void StringCalculatorAlphaStringReturnsZero()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("ABC");

        // Assert
        Assert.True(result.Equals(0));
    }

    [Fact]
    public void StringCalculatorTwoAlphaStringsReturnsZero()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("ABC,XYZ");

        // Assert
        Assert.True(result.Equals(0));
    }

    [Fact]
    public void StringCalculatorOneReturnsOne()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("1");

        // Assert
        Assert.True(result.Equals(1));
    }

    [Fact]
    public void StringCalculatorOnePlusTwoReturnsThree()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("1,2");

        // Assert
        Assert.True(result.Equals(3));
    }

    [Fact]
    public void StringCalculatorOnePlusTwoPlusThreePlusFourReturnsTen()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("1,2,3,4");

        // Assert
        Assert.True(result.Equals(10));
    }


    [Fact]
    public void StringCalculatorOnePlusTwoPlusBlankPlusFourReturnsSeven()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("1,2,,4");

        // Assert
        Assert.True(result.Equals(7));
    }

    [Fact]
    public void StringCalculatorOneNewlineTwoPlusThreeReturnsSix()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("1\n2,3");

        // Assert
        Assert.True(result.Equals(6));
    }
}
