namespace TestTaskMindBox;

public class Circle : IFigure
{
    double radius { get; set; }

    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Radius can not be negative");
        }
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.Round(Math.PI * radius * radius, 2);
    }
}
