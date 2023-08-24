namespace TestTaskMindBox;

public class Triangle : IFigure
{
    private double[] Sides { get; set; }

    public Triangle(double a, double b, double c)
    {
        if (!SidesAreValid(a, b, c))
        {
            throw new ArgumentException("Sides are invalid");
        }
        Sides = new double[] { a, b, c };
        Sides = Sides.OrderBy(x => x).ToArray();
    }

    public double CalculateArea()
    {
        if (TriangleIsRight())
        {
            return Math.Round((Sides[0] + Sides[1]) / 2, 2);
        }
        double halfPerimeter = Sides.Sum() / 2;
        return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2])), 2);
    }

    public bool TriangleIsRight()//является ли прямоугольным
    {
        double catheus1 = Sides[0];
        double catheus2 = Sides[1];
        double hypotenuse = Sides[2];

        return Math.Pow(catheus1, 2) + Math.Pow(catheus2, 2) == Math.Pow(hypotenuse, 2);
    }

    private bool SidesAreValid(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            return false;
        }

        double[] sides = new double[] { a, b, c };
        sides = sides.OrderBy(x => x).ToArray();

        return sides[0] + sides[1] >= sides[2];
    }
}
