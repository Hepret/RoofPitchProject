namespace RoofPitch;

public class EffortCalculation
{
    private readonly Point _point1;
    private readonly Point _point2;
    
    public double X1 => _point1.X;
    public double X2 => _point2.X;
    public double Y1 => _point1.Y;
    public double Y2 => _point2.Y;
    public string Name { get; }
    public double Length { get; }
    public double Effort { get; }

    public EffortCalculation(double p, Point point1, Point point2)
    {
        _point1 = point1;
        _point2 = point2;

        Name = $"{_point1.Name}-{_point2.Name}";
        Length = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        Effort = Length * p;
    }
}