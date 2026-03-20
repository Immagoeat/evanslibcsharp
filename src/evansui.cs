using System.Security.Cryptography;
using evanslib;
using evansmath;
using Raylib_cs;

namespace evansui{
public class EvansUI()
    {
        public static void createwindow(){ Raylib.InitWindow(800, 480, "Hello World");}
        public static void onstart(){Raylib.BeginDrawing();}
        public static void background(Raylib_cs.Color COLOR){Raylib.ClearBackground(COLOR);}

    }
}