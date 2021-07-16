using System;
using delegates;

Console.WriteLine("Hello World!");

var mathServ = new MathService();

mathServ.MathPerformed += delegate(object? sender, MathPerformedEventArgs e)
{
    Console.WriteLine("Result from delegate " + e.Result);
};

mathServ.MultiplyNumbers(32.323, 3423.23);