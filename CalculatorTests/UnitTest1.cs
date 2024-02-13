// CalculatorTests/UnitTest1.cs

using CalculatorLibrary;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void AddTest()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }

    // Repeat similar tests for other operations (subtract, multiply, divide)
}
