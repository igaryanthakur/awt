using System;

namespace WCFCalculator
{
    // Implement the service contract
    public class CalculatorService : ICalculatorService
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public string Divide(double a, double b)
        {
            if (b == 0)
                return "Error: Cannot divide by zero";
            return (a / b).ToString("F4");
        }

        public double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double AreaOfTriangle(double baseVal, double height)
        {
            return 0.5 * baseVal * height;
        }
    }
}
