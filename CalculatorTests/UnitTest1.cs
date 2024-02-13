// CalculatorTests/CalculatorTests.cs

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

    [Fact]
    public void SubtractTest()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Subtract(5, 3);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void MultiplyTest()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Multiply(2, 3);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void DivideTest()
    {
        // Arrange
        Calculator calculator = new Calculator();

        // Act
        int result = calculator.Divide(6, 2);

        // Assert
        Assert.Equal(3, result);
    }

    // Add more tests for edge cases, error handling, etc.
}
