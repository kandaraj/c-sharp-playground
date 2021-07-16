using System;
using delegates;

Console.WriteLine("Hello World!");

var mathServ = new MathService();

mathServ.MathPerformed += (object? sender, MathPerformedEventArgs e) 
    => Console.WriteLine("Result from lambda " + e.Result);
 

mathServ.MultiplyNumbers(32.323, 3423.23);