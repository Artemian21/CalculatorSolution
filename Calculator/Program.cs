namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            var calc = new Calculator();
            while (true)
            {
                Console.WriteLine("Enter first number (or 'exit' to quit):");
                string inputA = Console.ReadLine()!;
                if (inputA?.ToLower() == "exit") break;

                Console.WriteLine("Enter operator (+, -, *, /):");
                string op = Console.ReadLine()!;

                Console.WriteLine("Enter second number:");
                string inputB = Console.ReadLine()!;

                try
                {
                    double a = double.Parse(inputA);
                    double b = double.Parse(inputB);
                    double result = op switch
                    {
                        "+" => calc.add(a, b),
                        "-" => calc.Subtract(a, b),
                        "*" => calc.Multiply(a, b),
                        "/" => calc.Divide(a, b),
                        _ => throw new InvalidOperationException("Invalid operator")
                    };
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine();
            }
        }
    }
}

