using System;
using delegates;

Console.WriteLine("Hello World!");

var mathServ = new MathService();

mathServ.MathPerformed += (_, e) 
    => Console.WriteLine("Result from simplified lambda " + e.Result);
 

mathServ.MultiplyNumbers(32.323, 3423.23);