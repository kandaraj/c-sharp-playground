using System;

namespace delegates
{
    public class MathService
    {
        public Action<double> MathPerFormed;

        public delegate double CalculationHandler(double x, double y);
        
        public void CalculateNumbers(double x, double y, CalculationHandler calculation)
        {
            var result = calculation(x, y);
            MathPerFormed(result);
        }
    }
}