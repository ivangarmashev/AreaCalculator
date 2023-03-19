using AreaCalculator.Models;

namespace AreaCalculator.Tests;

public class CircleTests
{
    [Fact]
    public void CalculateArea_3_18_Return_31_769()
    {
        Assert.Equal(Math.Round(31.76904155, 5), Math.Round(new Circle(3.18).CalculateArea(), 5));
    }

    [Fact]
    public void Circle__minus_4_Throws_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-10));
    }
}