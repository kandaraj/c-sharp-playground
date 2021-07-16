using System;
using delegates;

Console.WriteLine("Hello World!");

var mathServ = new MathService();

mathServ.MathPerFormed = (result) => Console.WriteLine("Result from Action / Func " + result);

mathServ.CalculateNumbers(32.323, 3423.23, (x, y) => x * y);