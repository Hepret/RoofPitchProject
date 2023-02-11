namespace RoofPitch;

public class Program
{
    public static void Main()
    {
        var scheme = new StructureCalculationScheme(10, 10, 1.5, 0.45);
        var effortTable = new EffortCalculationTable(scheme);
        Console.WriteLine(scheme.F);
        
        effortTable.PrintTable();
    }
}

