using System;
using tuples;

Console.WriteLine("Tuples");

// null check 
string s = "null";
_ = s ?? throw new Exception("It is null");

// tuples switch

var bool1 = true;
var bool2 = "Siva";

var value = (bool1, bool2) switch {
    (true, "siva") =>  1,
    (false, "siva") => 0,
    (_, _) => 12
};

Console.WriteLine(value);

// using struct
var point = new Point(1021.12);

Console.WriteLine($"Point X {point.X}");
