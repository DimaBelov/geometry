namespace Geometry.Core
{
    /// <inheritdoc />
    /// <summary>
    /// Базовый класс плоской геометрической фигуры
    /// </summary>
    public abstract class Shape : IShape
    {
        public abstract double Area();
    }
}
