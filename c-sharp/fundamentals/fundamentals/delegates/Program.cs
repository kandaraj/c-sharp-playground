using System;
using delegates;

Console.WriteLine("Hello World!");

var mathServ = new MathService();

mathServ.MathPerformed += OnMathPerformed;

mathServ.MultiplyNumbers(32.323, 3423.23);

static void OnMathPerformed(object o, MathPerformedEventArgs e)
{
    Console.WriteLine("Result " + e.Result);
}