namespace Geometry.Core
{
    /// <summary>
    /// Базовый класс плоской геометрической фигуры
    /// </summary>
    public abstract class Shape : IShape
    {
        public abstract double Area();
    }
}
