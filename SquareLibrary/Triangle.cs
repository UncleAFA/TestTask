namespace SquareLibrary
{
    public class Triangle : IShape
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Длина сторон должна быть положительной.");
            }

            if (a + b <= c || b + c <= a || c + a <= b)
            {
                throw new ArgumentException("Недопустимые стороны треугольника.");
            }

            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        public bool IsRectangularTriangle()
        {
            double[] sides = [A, B, C];
            Array.Sort(sides);

            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 0.0001;
        }
    }
}
