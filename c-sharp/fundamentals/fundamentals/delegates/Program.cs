using System;
using delegates;

Console.WriteLine("Hello World!");

var mathServ = new MathService();

mathServ.MathPerformed += (result) => Console.WriteLine("Result from execution " + result);

mathServ.CalculateNumbers(32.323, 3423.23, (x, y) => x * y);