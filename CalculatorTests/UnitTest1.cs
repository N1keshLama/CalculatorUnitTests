// CalculatorTests/CalculatorTests.cs

using CalculatorLibrary;
using Xunit;

public class CalculatorTests
{
    [Fact]
    public void AddTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void AddHandlesNegativeNumbers()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(-2, 3);
        Assert.Equal(1, result);
    }

    [Fact]
    public void AddHandlesLargeNumbers()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(int.MaxValue, 1);
        Assert.Equal(int.MinValue, result);
    }

    [Fact]
    public void AddHandlesZero()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(0, 5);
        Assert.Equal(5, result);
    }

    [Fact]
    public void AddHandlesBothZero()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Add(0, 0);
        Assert.Equal(0, result);
    }

    [Fact]
    public void SubtractTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtract(5, 3);
        Assert.Equal(2, result);
    }

    [Fact]
    public void SubtractHandlesNegativeResult()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtract(3, 5);
        Assert.Equal(-2, result);
    }

    [Fact]
    public void SubtractHandlesLargeNumbers()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtract(int.MaxValue, -1);
        Assert.Equal(int.MinValue, result);
    }

    [Fact]
    public void SubtractHandlesZero()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtract(5, 0);
        Assert.Equal(5, result);
    }

    [Fact]
    public void SubtractHandlesBothZero()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Subtract(0, 0);
        Assert.Equal(0, result);
    }

    [Fact]
    public void MultiplyTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Multiply(2, 3);
        Assert.Equal(6, result);
    }

    [Fact]
    public void MultiplyByZeroReturnsZero()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Multiply(2, 0);
        Assert.Equal(0, result);
    }

    [Fact]
    public void MultiplyHandlesLargeNumbers()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Multiply(int.MaxValue, 2);
        Assert.Equal(int.MinValue + 1, result);
    }

    [Fact]
    public void MultiplyHandlesNegativeNumbers()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Multiply(-2, 3);
        Assert.Equal(-6, result);
    }

    [Fact]
    public void DivideTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Divide(6, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void DivideByZeroThrowsException()
    {
        Calculator calculator = new Calculator();
        Assert.Throws<ArgumentException>(() => calculator.Divide(6, 0));
    }

    [Fact]
    public void DivideHandlesLargeNumbers()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Divide(int.MaxValue, 2);
        Assert.Equal(int.MaxValue / 2, result);
    }

    [Fact]
    public void DivideHandlesNegativeResult()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Divide(-6, 2);
        Assert.Equal(-3, result);
    }

    [Fact]
    public void DivideHandlesZero()
    {
        Calculator calculator = new Calculator();
        int result = calculator.Divide(0, 5);
        Assert.Equal(0, result);
    }

    [Fact]
    public void DivideHandlesBothZero()
    {
        Calculator calculator = new Calculator();
        Assert.Throws<ArgumentException>(() => calculator.Divide(0, 0));
    }
}