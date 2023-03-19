using AreaCalculator.Models;

namespace AreaCalculator.Tests;

public class PolygonTests
{
    [Fact]
    public void Polygon_0_1_1_2_Throws_ArgumentException()
    {
        Vertex[] vertices =
        {
            new Vertex(0, 1),
            new Vertex(1, 2)
        };
        Assert.Throws<ArgumentException>(() => new Polygon(vertices));
    }

    [Fact]
    public void Polygon_0_0_0_Return_0()
    {
        Vertex[] vertices =
        {
            new Vertex(0, 0),
            new Vertex(0, 0),
            new Vertex(0, 0)
        };

        Assert.Equal(0, new Polygon(vertices).CalculateArea());
    }
    
    [Fact]
    public void CalculateArea_Return_60()
    {
        Vertex[] vertices =
        {
            new Vertex(3, 4),
            new Vertex(5, 11),
            new Vertex(12, 8),
            new Vertex(9, 5),
            new Vertex(5, 6)
        };
        Assert.Equal(30, new Polygon(vertices).CalculateArea());
    }
}