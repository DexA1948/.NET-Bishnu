using System;

public class ExceptionHandling
{
    public double Compute(double x, double y, double z)
    {
        double c = 0;
        try 
        {
            double value = (x + y) / z;
            c = value * x / (y + z);
        }
        catch(ArithmeticException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if(c == 0)
                c = 20;
        }

        return c;
    }



    public void Test()
    {
        var v = Compute(23, 45, 0);
    }
}