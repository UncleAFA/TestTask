namespace SquareLibrary
{
    public class AreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
