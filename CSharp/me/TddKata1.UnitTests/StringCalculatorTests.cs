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
        Assert.Equal(0, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorAlphaStringReturnsZero()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("ABC");

        // Assert
        Assert.Equal(0, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorTwoAlphaStringsReturnsZero()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("ABC,XYZ");

        // Assert
        Assert.Equal(0, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorOneReturnsOne()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add("1");

        // Assert
        Assert.Equal(1, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorOnePlusTwoReturnsThree()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add($"//,\n1,2");

        // Assert
        Assert.Equal(3, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorOnePlusTwoPlusThreePlusFourReturnsTen()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add($"//,\n1,2,3,4");

        // Assert
        Assert.Equal(10, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }


    [Fact]
    public void StringCalculatorOnePlusTwoPlusBlankPlusFourReturnsSeven()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add($"//,\n1,2,,4");

        // Assert
        Assert.Equal(7, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorOneNewlineTwoPlusThreeReturnsSix()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add($"//,\n1\n2,3");

        // Assert
        Assert.Equal(6, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorNoDelimiterHeaderReturnsSix()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add($"1;2;3");

        // Assert
        Assert.Equal(6, result.Total);
        Assert.True(result.IsSuccess);
        Assert.Null(result.Message);
    }

    [Fact]
    public void StringCalculatorNegitiveNumberReturnsFour()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add($"1;-2;3");

        // Assert
        Assert.Equal(4, result.Total);
        Assert.False(result.IsSuccess);
        Assert.NotNull(result.Message);
    }

    [Fact]
    public void StringCalculatorMultipleNegitiveNumberReturnsFour()
    {
        // Arrange

        // Act
        var result = StringCalculator.Add($"1;-2;5;-1");

        // Assert
        Assert.Equal(6, result.Total);
        Assert.False(result.IsSuccess);
        Assert.NotNull(result.Message);
    }
}
