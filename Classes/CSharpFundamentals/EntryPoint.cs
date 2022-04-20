using ABC;
public class Program
{
    public static void Main()
    {
        BasicCalculator calculator1 = new(34.6, 35.6);
        var y = BasicCalculator.brand;

        var s2 = calculator1.Sum();
        var d2 = calculator1.Subtract();
        var m2 = calculator1.Multiply();
        var di2 = calculator1.Divide();
    }
}