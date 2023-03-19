using System;
using System.Linq;

namespace AreaCalculator.Models
{
    /// <summary>
    /// Класс для работы с треугольниками
    /// </summary>
    public class Triangle : Shape
    {
        private readonly double _firstSide, _secondSide, _thirdSide;

        private double[] Sides => new double[] { _firstSide, _secondSide, _thirdSide };
        
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if(firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Side length is less than or equal to zero.");
            
            if (firstSide + secondSide < thirdSide ||
                secondSide + thirdSide < firstSide ||
                firstSide + thirdSide < secondSide)
                throw new ArgumentException("Sum of the two sides is less than the third.");

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public override double CalculateArea()
        {
            double halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) * (halfPerimeter - _secondSide) * (halfPerimeter - _thirdSide));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular
        {
            get
            {
                Array.Sort(Sides);
                return Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2) == Math.Pow(Sides[2], 2);
            }
        }
    }
}

