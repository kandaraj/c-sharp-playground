using System;

namespace delegates
{
    public class MathService
    {
        public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public void MultiplyNumbers(double x, double y)
        {
            MathPerformed(this, new MathPerformedEventArgs
            {
                Result = x * y
            });
        }
    }

    public class MathPerformedEventArgs: EventArgs
    {
        public double Result { get; set; }
    }
}