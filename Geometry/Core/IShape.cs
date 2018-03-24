namespace Geometry.Core
{
    /// <summary>
    /// Плоская геометрическая фигура
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Вычесляет площадь фигуры
        /// </summary>
        /// <returns></returns>
        double Area();
    }
}
