using System;
using Geometry.Core;

namespace Geometry.Shapes
{
    /// <inheritdoc />
    /// <summary>
    /// Класс окружности
    /// </summary>
    public class Circle : Shape
    {
        /// <inheritdoc />
        /// <summary>
        /// Возвращает новый экземпляр окружности
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
