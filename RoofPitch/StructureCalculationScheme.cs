namespace RoofPitch;

public class StructureCalculationScheme
{
    public double L { get; set; }
    public double P { get; set; }
    public double A_B { get; set; }
    public double F { get; set; }
    public double K => (A + B) / (2 * B);
    public double RY => (1 + 2 * K) / 2;
    public double N => 2F / L;
    public double A => B * A_B;
    public double B => L / 2 / (1 + A_B);
    public double C => D * A_B;
    public double D => F / (1 + A_B);
}