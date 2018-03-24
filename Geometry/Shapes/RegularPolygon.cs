using System;
using System.Linq;

namespace Geometry.Shapes
{
    /// <inheritdoc />
    /// <summary>
    /// Класс правильного многоугольника
    /// </summary>
    public class RegularPolygon : Polygon
    {
        /// <summary>
        /// треугольник:
        /// основание - сторона правильного многоугольника,
        /// рёбра - радиусы описанной окружности правильного многоугольника
        /// </summary>
        readonly Triangle _partialTriangle;

        /// <inheritdoc />
        /// <summary>
        /// Возвращает новый экземпляр правильного многоугольника
        /// </summary>
        /// <param name="side">Сторона правильного многоугольника</param>
        /// <param name="topCount">Количество вершин</param>
        public RegularPolygon(double side, int topCount) : base(GetSidesList(side, topCount))
        {
            var circumscribedCircleRadius = Sides.First() / (2 * Math.Sin(Math.PI / Sides.Count));
            _partialTriangle = new Triangle(Sides.First(), circumscribedCircleRadius, circumscribedCircleRadius);
        }

        static double[] GetSidesList(double side, int topCount)
        {
            var sides = new double[topCount];
            for (var i = 0; i < topCount; i++)
                sides.SetValue(side, i);
            return sides;
        }

        /// <summary>
        /// Вычисление площади правильного многоугольника (путём разбиения его на равные равнобедренные треугольники)
        /// </summary>
        /// <returns>Площадь правильного многоугольника</returns>
        public override double Area()
        {
            return Sides.Count * _partialTriangle.Area();
        }
    }
}
