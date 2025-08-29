using Drawing;


public class Circle : Shape, IDisposable
{
    public Point Center { get; set; }
    public int Radius { get; set; }

    public Circle(Point center, int radius, Color color, int thickness)
    {
        Center = center;
        Radius = radius;
        ShapeColor = color;
        Thickness = thickness;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {ShapeColor} circle at {Center} with radius {Radius} and thickness {Thickness}");
    }

    ~Circle()
    {
        // Cleanup if necessary
    }

    public void Dispose()
    {
        // Cleanup if necessary
        GC.SuppressFinalize(this);
    }


    public void Calculate(out double area, out double circumference)
    {
        area = Math.PI * Radius * Radius;
        circumference = 2 * Math.PI * Radius;

    }
}
