class Methods
{
    // 1. No return value, no parameter
    void PrintHello()
    {
        Console.WriteLine("Hello there!!");
    }

    // 2. No return value but single parameter
    void PrintHello(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

    // 3. return value and two parameters
    string FormatName1(string firstName, string lastName)
    {
        return $"{lastName}, {firstName}";
    }

    // 4. Expression syntax
    string FormatName2(string firstName, string lastName) => $"{lastName}, {firstName}";
    bool IsEven(short number) => number % 2 == 0;

    // 5. Varaible number of arguments
    public double Sum(params double[] numbers) => numbers.Sum();

    // 6. Optional arguments
    public string Greet(string firstName, string lastName, string salutation = "Mr.") => 
        $"Hello, {salutation} {firstName} {lastName}";

    // 7. Returning multiple values using tuples
    public (double, double) CalcSumAndAverage()
    {
        double av = 45.6;
        double sum = 34535.6;
        return (av, sum);
    }
}