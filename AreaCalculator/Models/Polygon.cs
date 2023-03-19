using System;

namespace AreaCalculator.Models
{
    /// <summary>
    /// Класс для расчета площади фигуры по её вершинам.
    /// </summary>
    public class Polygon : Shape
    {
        private readonly Vertex[] _vertices;

        /// <summary>
        /// Многоугольник
        /// </summary>
        /// <param name="vertices">Координаты многоугольника по порядку (не меньше 3-ех)</param>
        /// <exception cref="ArgumentException">Выбрасывается если передано меньше трех вершин</exception>
        public Polygon(Vertex[] vertices)
        {
            if (vertices.Length < 3)
                throw new ArgumentException("Vertices less than 3");        
            _vertices = vertices;
        }
        
        public override double CalculateArea()
        {
            int verticesCount = _vertices.Length;
            double sum = 0.0;

            for (int i = 0; i < verticesCount; i++)
            {
                int prevIndex;
                if (i == 0)
                    prevIndex = verticesCount - 1;
                else
                    prevIndex = i - 1;

                sum += _vertices[prevIndex].X * _vertices[i].Y - _vertices[i].X * _vertices[prevIndex].Y;
            }
            return 0.5 * Math.Abs(sum);
        }
    }
}

