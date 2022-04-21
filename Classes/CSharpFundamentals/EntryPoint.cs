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


        for (long i = 10; i < 20; i++)
        {
            Console.WriteLine("Hi");
        }

        double[] weights = { 34.5, 67.8, 23.5, 34.1 };
        var t = weights[4];

        for(byte j = 0; j < weights.Length; j++)
        {
            Console.WriteLine(weights[j]);
        }

        foreach(var x in weights)
        {
            Console.WriteLine(x);
        }

    }
}