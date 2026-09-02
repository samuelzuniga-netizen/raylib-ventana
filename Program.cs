using Raylib_cs;

namespace S079PixelLab;

internal static class Program
{
    public static void Main(){
    const int anchoVentana = 800;
    const int altoVentana = 600;

    Raylib.InitWindow(anchoVentana, altoVentana, "Pixcel lab 16x16");
    Raylib.SetTargetFPS(60);

    while (!Raylib.WindowShouldClose())
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("Pixel lab 16x16", 20, 20, 20, Color.Maroon);
        Raylib.DrawText("Esc: cerrar", 20, 52, 18, Color.Gray);

        Raylib.EndDrawing();
    }
    Raylib.CloseWindow();
    }
}