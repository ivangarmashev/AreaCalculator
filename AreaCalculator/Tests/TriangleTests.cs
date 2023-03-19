using AreaCalculator.Models;

namespace AreaCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void CalculateArea_3_4_5_Return_6()
    {
        Assert.Equal(6, new Triangle(3, 4, 5).CalculateArea());
    }

    [Fact]
    public void Triangle_6_1000_3_Throws_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(6, 1000, 3));
    }
    
    [Fact]
    public void Triangle_6__minus__4_3_Throws_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(6, -4, 3));
    }
    
    [Fact]
    public void Triangle_0_0_0_Throws_ArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
    }
    
    [Fact]
    public void IsRectangle_3_4_5_Returns_True()
    {
        Assert.True(new Triangle(3, 4, 5).IsRectangular);
    }
    
    [Fact]
    public void IsRectangle_3_4_6_Returns_False()
    {
        Assert.False(new Triangle(3, 4, 5.00000001).IsRectangular);
    }
    
    
}