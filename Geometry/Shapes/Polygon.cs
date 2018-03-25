using System;
using System.Collections.Generic;
using System.Linq;
using Geometry.Core;

namespace Geometry.Shapes
{
    /// <inheritdoc />
    /// <summary>
    /// Базовый класс многоугольника
    /// </summary>
    public abstract class Polygon : Shape
    {
        protected readonly List<double> Sides;

        protected Polygon(params double[] sides)
        {
            if(sides.Length < 3)
                throw new ArgumentException("Для построения многоугольника необходимо минимум 3 стороны");

            Sides = sides.ToList();
        }
    }
}
