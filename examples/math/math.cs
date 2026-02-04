using System;
using evansmath;
using evanslib;

class Program
{

    public static void Main(string[] args)
    {
        Evansmath.DebugMode = false;
        //var bob = Evansmath.FindX("17x - 42 + 8x - 13 - 6x + 91 - 25x + 4 + 39x - 7 - 18 + 2x - 11 = 54x - 120 + 6 - 31x + 9x - 14");
        //var bob = Evansmath.PercentOf("1% of 2");
        var bob = Evansmath.PercentChange(1, 2);
        //var bob = Evansmath.Add(1, 2);
        //var bob = Evansmath.Subtract(1, 2);
        //var bob = Evansmath.Multiply(1, 2);
        //var bob = Evansmath.Divide(0, 0);
        Evanslib.Print(bob);
    }    

}