namespace SquareLibrary
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }

            Radius = radius;
        }

        public double GetArea() => Math.PI * Math.Pow(this.Radius, 2);
    }
}