namespace RoofPitch;

public class Point
{
    public string Name { get; set; } = "Unnamed";
    public double X { get; set; }
    public double Y { get; set; }

    public Point() {}
    
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }

    public override string ToString()
    {
        return $"X: {Math.Round(X,5)}, Y: {Math.Round(Y,5)}";
    }
}