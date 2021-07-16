using System;

namespace delegates
{
    public class MathService
    {
        public delegate void MathFormedHandler(double result);

        public event MathFormedHandler MathPerformed;
        
        public void MultiplyNumbers(double x, double y)
        {
            MathPerformed(x * y);
        }
    }
}