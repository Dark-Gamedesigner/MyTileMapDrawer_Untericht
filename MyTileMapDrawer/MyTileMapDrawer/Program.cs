using Raylib_cs;

namespace MyTileMapDrawer;

class Program
{
    static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        Raylib.InitWindow(800, 600,"TileMaps! :D");
        while (!Raylib.WindowShouldClose()){
            Raylib.BeginDrawing();
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}