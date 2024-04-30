using NUnit.Framework;

namespace SquareLibraryTests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TriangleValidSidesReturnsCorrectArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expectedArea = 6;

            var triangle = new SquareLibrary.Triangle(a, b, c);
            double actualArea = triangle.GetArea();

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001), "Неверно рассчитана площадь треугольника.");
        }

        [Test]
        public void TriangleInvalidSidesThrowsArgumentException()
        {
            double a = 1;
            double b = 2;
            double c = 10;

            Assert.Throws<ArgumentException>(() => new SquareLibrary.Triangle(a, b, c));
        }

        [Test]
        public void TriangleNegativeSideThrowsArgumentException()
        {
            double a = -3;
            double b = 4;
            double c = 5;

            Assert.Throws<ArgumentException>(() => new SquareLibrary.Triangle(a, b, c));
        }

        [Test]
        public void IsRectangularTriangleRectangularTriangleReturnsTrue()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            var triangle = new SquareLibrary.Triangle(a, b, c);

            bool isRectangular = triangle.IsRectangularTriangle();

            Assert.That(isRectangular, "Ожидаемый треугольник должен быть прямоугольным.");
        }

        [Test]
        public void IsRectangularTriangleNotRectangularTriangleReturnsFalse()
        {
            double a = 3;
            double b = 4;
            double c = 6;

            var triangle = new SquareLibrary.Triangle(a, b, c);

            bool isRectangular = triangle.IsRectangularTriangle();

            Assert.That(!isRectangular, "Ожидаемый треугольник не должен быть прямоугольным.");
        }
    }
}
