namespace RoofPitch;

public class EffortCalculationTable
{
    private readonly StructureCalculationScheme _scheme;
    private Dictionary<string, Point> Points => _scheme.Points;
    private double P => _scheme.P;
    public List<EffortCalculation> EffortCalculationTableList { get; }

    public EffortCalculationTable(StructureCalculationScheme scheme)
    {
        this._scheme = scheme;
        EffortCalculationTableList = new List<EffortCalculation>();
        EffortCalculationTableList = GetEffortCalculationTable();
    }

    private List<EffortCalculation> GetEffortCalculationTable()
    {
        var effortCalculationTable = new List<EffortCalculation>();

        var point1 = Points["1"];
        var point2 = Points["8"];
        
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        
        point1 = Points["1"];
        point2 = Points["6"];
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        
        point1 = Points["2"];
        point2 = Points["6"];
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        
        point1 = Points["3"];
        point2 = Points["7а"];
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        
        point1 = Points["4"];
        point2 = Points["7б"];
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        
        point1 = Points["5"];
        point2 = Points["8"];
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        
        point1 = Points["6"];
        point2 = Points["7а"];
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        
        point1 = Points["7б"];
        point2 = Points["8"];
        effortCalculationTable.Add(new EffortCalculation(P, point1, point2));
        return effortCalculationTable;
    }

    public void PrintTable()
    {
        foreach (var effortCalculation in EffortCalculationTableList)
        {
            Console.WriteLine($"Name: {effortCalculation.Name}, Length: {Math.Round(effortCalculation.Length,5)}, Effort: {Math.Round(effortCalculation.Effort, 3)}");
        }
    }
}