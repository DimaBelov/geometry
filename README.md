# geometry

Проект содержит классы различных плоских геометрических фигур. Каждый из этих классов наследует бызовый абстрактный класс плоской геометрической фигуры (Geometry.Core.Shape).
Geometry.Core.Shape реализует интерфейс Geometry.Core.IShape, предоставляющий метод для расчёта площади, но делает этот метод абстрактым, оставляя реализацию классам наследникам.

Geometry.Shapes.Circle - окружность
Geometry.Shapes.Polygon - базовый абстрактный класс многоугольника
Geometry.Shapes.Triangle - треугольник
Geometry.Shapes.Rectangle - прямоугольник
Geometry.Shapes.RegularPolygon - правильный многоугольник