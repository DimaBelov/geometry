using System;
using System.Linq;

namespace Geometry.Shapes
{
    /// <inheritdoc />
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : Polygon
    {
        readonly double _halfPerimeter;

        /// <inheritdoc />
        /// <summary>
        /// Возвращает новый экземпляр треугольника
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        public Triangle(double a, double b, double c) : base(a, b, c)
        {
            _halfPerimeter = Sides.Sum() / 2;
            if(_halfPerimeter <= Sides.Max())
                throw new ArgumentOutOfRangeException("Полупериметр треугольника должен быть больше любой его стороны");

            IsRightTriangle = DefineIsRightTriangle();
        }

        /// <summary>
        /// Признак прямоугольного треугольника
        /// </summary>
        public bool IsRightTriangle { get; }
        
        bool DefineIsRightTriangle()
        {
            var hypotenuse = Sides.Max();
            var legs = Sides.Where(s => Math.Abs(s - hypotenuse) > double.Epsilon).ToList();
            return Math.Abs(
                       Math.Pow(hypotenuse, 2) - (Math.Pow(legs[0], 2) + Math.Pow(legs[1], 2)))
                   < double.Epsilon;
        }

        /// <summary>
        /// Вычисление площади треугольника (по формуле Герона)
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double Area()
        {
            return Math.Sqrt(_halfPerimeter * (_halfPerimeter - Sides[0]) * (_halfPerimeter - Sides[1]) * (_halfPerimeter - Sides[2]));
        }
    }
}
