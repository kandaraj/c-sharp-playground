using System;

namespace delegates
{
    public class MathService
    {
        public delegate void MathFormedHandler(double result);

        public delegate double CalculationHandler(double x, double y);

        public event MathFormedHandler MathPerformed;
        
        public void CalculateNumbers(double x, double y, CalculationHandler calculation)
        {
            var result = calculation(x, y);
            MathPerformed(result);
        }
    }
}