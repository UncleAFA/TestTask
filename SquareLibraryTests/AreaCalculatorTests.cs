using NUnit.Framework;

namespace SquareLibraryTests
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        [Test]
        public void AreaCalculatorCalculateArea_Circle()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            var circle = new SquareLibrary.Circle(radius);
            var calculator = new SquareLibrary.AreaCalculator();

            double actualArea = SquareLibrary.AreaCalculator.CalculateArea(circle);

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001), "Калькулятор площади неправильно рассчитал площадь окружности.");
        }

        [Test]
        public void AreaCalculatorCalculateArea_Triangle()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            double expectedArea = 6;

            var triangle = new SquareLibrary.Triangle(a, b, c);
            var calculator = new SquareLibrary.AreaCalculator();

            double actualArea = SquareLibrary.AreaCalculator.CalculateArea(triangle);

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001), "Калькулятор площади неправильно рассчитал площадь треугольника.");
        }
    }
}
