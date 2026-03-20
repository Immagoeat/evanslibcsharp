using Raylib_cs;
using evansui;
using System.Diagnostics.Contracts;

namespace HelloWorld;

internal static class Program
{
    // STAThread is required if you deploy using NativeAOT on Windows - See https://github.com/raylib-cs/raylib-cs/issues/301
    [System.STAThread]
    public static void Main()
    {
        EvansUI.createwindow();

        while (!Raylib.WindowShouldClose())
        {
            EvansUI.onstart();
            EvansUI.background(Raylib_cs.Color.Blue);

            Raylib.DrawText("Hello, world!", 12, 12, 20, Color.Black);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}