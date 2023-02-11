namespace RoofPitch;

public class StructureCalculationScheme
{
    public double L { get; set; }
    public double P { get; set; }
    public double A_B { get; set; }
    public double F { get; set; }
    public double K => Math.Round((A + B) / (2 * B), 2);
    public double RY => Math.Round((1 + 2 * K) / 2, 2);
    public double N => Math.Round(2*F / L, 2);
    public double A => Math.Round(B * A_B, 2);
    public double B => Math.Round( L / 2 / (1 + A_B), 2);
    public double C => Math.Round(D * A_B, 2);
    public double D => Math.Round(F / (1 + A_B), 2);
    public Dictionary<string,Point> Points { get; }
    public StructureCalculationScheme(double l, double p, double aB, double f)
    {   
        L = l;
        P = p;
        A_B = aB;
        F = f;
        Points = GetPoints();
    }
    private Dictionary<string, Point> GetPoints()
    {
        var points = new Dictionary<string, Point>
        {
            { "1", new Point(0, 0, "1") },
            { "2", new Point(0, RY, "2") }
        };

        var y3 = points["2"].Y - K;
        points.Add("3", new Point(0, y3, "3"));
        
        var y4 = points["3"].Y - 1;
        points.Add("4", new Point(0, y4, "4") );
        
        var y5 = points["4"].Y - K;
        points.Add("5", new Point(0, y5, "5"));

        var x6 = -3.5 * RY / (2 * N);
        var y6 = x6 * N + RY;
        points.Add("6", new Point(x6, y6, "6"));

        var x7A = -0.7 * (RY - K - 2 * y6) / N;
        var y7A = x7A * N + RY - K;
        points.Add("7а", new Point(x7A,y7A, "7а"));

        var x7B = x7A;
        var y7B = -y7A;
        points.Add("7б", new Point(x7B, y7B, "7б"));

        var x8 = x6;
        var y8 = -y6;
        points.Add("8", new Point(x8,y8, "8"));
        

        return points;
    }
    public void PrintPoints()
    {
        foreach (var kvp in Points)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
    
}