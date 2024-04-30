using NUnit.Framework;

namespace SquareLibraryTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CircleValidRadiusReturnsCorrectArea()
        {
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);

            var circle = new SquareLibrary.Circle(radius);
            double actualArea = circle.GetArea();

            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.0001), "Неверно рассчитана площадь окружности.");
        }

        [Test]
        public void CircleNegativeRadiusThrowsArgumentException()
        {
            double radius = -5;

            Assert.Throws<ArgumentException>(() => new SquareLibrary.Circle(radius));
        }
    }
}
