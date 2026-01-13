using System;
using evansmath;
using evanslib;

class Program
{

    public static void Main(string[] args)
    {
        //x = -44
        var bob = Evansmath.FindX("17x - 42 + 8x - 13 - 6x + 91 - 25x + 4 + 39x - 7 - 18 + 2x - 11 = 54x - 120 + 6 - 31x + 9x - 14");
        Evanslib.Print(bob);
    }    

}