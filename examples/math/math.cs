using System;
using evansmath;
using evanslib;

class Program
{

    public static void Main(string[] args)
    {
        var bob = Evansmath.FindX("2x + 2 = x + 4");
        Evanslib.Print(bob);
    }    

}