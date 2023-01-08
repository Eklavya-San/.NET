namespace Drawing;

public class Line : Shape
{
    public Point StartPoint
    {
        get;
        set;
    }
    public Point EndPoint
    {
        get;
        set;
    }

    public Line()
    {
        this.StartPoint = new Point(0, 0);
        this.EndPoint = new Point(0, 0);
    }
    public Line(Point SPoint, Point EPoint)
    {
        this.StartPoint = SPoint;
        this.EndPoint = EndPoint;
    }
    public override void Draw()
    {
        Type t = this.GetType();
        Console.WriteLine("Type =" + t.Name);
        Console.WriteLine("(" + this.StartPoint + "), (" + this.EndPoint + ")," +
          "," + this.Color);

    }
}