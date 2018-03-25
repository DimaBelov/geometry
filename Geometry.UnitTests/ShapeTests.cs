using System;
using Geometry.Shapes;
using Xunit;

namespace Geometry.UnitTests
{
    public class ShapeTests
    {
        [Theory]
        [InlineData(1)]
        public void IsCircleAreaCorrectTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.Equal(
                Math.PI * Math.Pow(radius, 2),
                circle.Area());
        }

        [Theory]
        [InlineData(1.5, 2, 3)]
        public void IsTriangleAreaCorrectTest(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            var halfPerimiter = (a + b + c) / 2;
            Assert.Equal(
                Math.Sqrt(halfPerimiter * (halfPerimiter - a) * (halfPerimiter - b) * (halfPerimiter - c)),
                triangle.Area());
        }

        [Theory]
        [InlineData(3, 4, 5)]
        public void IsTriangleRightTest(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.Equal(true, triangle.IsRightTriangle);
        }

        [Theory]
        [InlineData(3, 5)]
        public void IsRegularPolygonAreaCorrectTest(double side, int topCount)
        {
            var regularPolygon = new RegularPolygon(side, topCount);
            var circumscribedCircleRadius = side / (2 * Math.Sin(Math.PI / topCount));
            var triangle = new Triangle(side, circumscribedCircleRadius, circumscribedCircleRadius);
            Assert.Equal(5 * triangle.Area(), regularPolygon.Area());
        }

        [Theory]
        [InlineData(5, 7)]
        public void IsRectangleAreaCorrectTest(double basis, double height)
        {
            var rectangle = new Rectangle(basis, height);
            Assert.Equal(basis * height, rectangle.Area());
        }
    }
}
