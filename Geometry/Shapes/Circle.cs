﻿using System;
using Geometry.Core;

namespace Geometry.Shapes
{
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

        public double Radius { get; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
