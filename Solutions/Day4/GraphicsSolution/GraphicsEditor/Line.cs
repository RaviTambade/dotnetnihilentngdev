
namespace Drawing;


//Class Relationships
//Is a--- inheritance
//Has a--- composition
//Uses a--- aggregation

//Deterministic Finalization

public class Line : Shape, IDisposable
{
    public Point Start { get; set; }
    public Point End { get; set; }
 

    public Line()
    {
        Start = new Point();
        End = new Point();
    }

    public Line(Point start, Point end, Color color, int thickness)
    {
        Start = start;
        End = end;
        ShapeColor = color;
        Thickness = thickness;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a {ShapeColor} line from {Start} to {End} with thickness {Thickness}");



    }

    //Destructor is automatically invoked by the garbage collector

    //Indeterministic Finalization

    ~Line()
    {
        //Connection Close
        //Socket close
        //Release resources which are acquired during the lifetime of the object
        // Cleanup if necessary
    }


    public void Dispose()
    {
        //Connection Close
        //Socket close
        //Release resources which are acquired during the lifetime of the object
        // Cleanup if necessary
        // Call Dispose on any IDisposable members
        GC.SuppressFinalize(this);
    }
}
