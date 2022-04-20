// Design a basic calculator

namespace ABC;
public class BasicCalculator
{
    public BasicCalculator(double op1, double op2)
    {
        operand1 = op1;
        operand2 = op2;
    }

    public static string brand = "Boat";
    double operand1;
    double operand2;

    public double Sum() => operand1 + operand2;
    public double Subtract() => operand1 - operand2;
    public double Multiply() => operand1 * operand2;
    public double Divide() => operand1 / operand2;
}
