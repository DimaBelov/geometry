using System.Linq;

namespace Geometry.Shapes
{
    /// <inheritdoc />
    /// <summary>
    /// Класс прямоугольника
    /// </summary>
    public class Rectangle : Polygon
    {
        /// <inheritdoc />
        /// <summary>
        /// Возвращает новый экземпляр прямоугольника
        /// </summary>
        /// <param name="basis">Основание</param>
        /// <param name="height">Высота</param>
        public Rectangle(double basis, double height) : base(basis, height, basis, height) { }

        /// <summary>
        /// Вычисление площади прямоугольника (путём умножения основания на высоту)
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        public override double Area()
        {
            return Sides.Min() * Sides.Max();
        }
    }
}
