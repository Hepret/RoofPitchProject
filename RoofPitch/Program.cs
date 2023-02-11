namespace RoofPitch;

public class Program
{
    public static void Main()
    {
        var scheme = new StructureCalculationScheme(12, 10, 1.5, 2.7);
        scheme.PrintPoints();
    }
}

