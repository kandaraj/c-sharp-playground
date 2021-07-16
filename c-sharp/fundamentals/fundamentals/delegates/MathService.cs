using System;

namespace delegates
{
    public class MathService
    {
        public Action<double> MathPerFormed;
        public void CalculateNumbers(double x, double y, Func<double, double, double> calculation)
        {
            var result = calculation(x, y);
            MathPerFormed(result);
        }
    }
}