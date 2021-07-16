using System;
using delegates;

Console.WriteLine("Hello World!");

var mathServ = new MathService();

mathServ.MathPerformed += (result)
    => Console.WriteLine("Result from delegate simple " + result);
 

mathServ.MultiplyNumbers(32.323, 3423.23);