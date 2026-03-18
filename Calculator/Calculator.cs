using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        // Додавання
        public int add(int a, int b) { return a + b; }

        // Віднімання
        public double Subtract(double a, double b) => a - b;

        // Ділення
        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }

        // Множення
        public double Multiply(double a, double b) => a * b;
    }
}
