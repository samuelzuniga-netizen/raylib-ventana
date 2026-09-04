using System.Runtime.Serialization;
using Raylib_cs;

namespace S079PixelLab;

internal static class Program
{
    public static void Main(){
    const int anchoVentana = 800;
    const int altoVentana = 600;
    const int celda = 100;
    const int origenX = 100;
    const int origenY = 100;

    Raylib.InitWindow(anchoVentana, altoVentana, "Pixcel lab 16x16");
    Raylib.SetTargetFPS(60);

    while (!Raylib.WindowShouldClose())
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RayWhite);
        int[,] imagen = {
        {1, 0, 0, 1},
        {0, 0, 0, 0},
        {1, 0, 0, 1},
        {0, 1, 1, 0}
    };

    for (int fila = 0; fila < 4; fila++)
    for (int col = 0; col < 4; col++)
    {
        int x = origenX + col * celda;
        int y = origenY + fila * celda;
        if (imagen[fila, col] == 1)
        Raylib.DrawRectangle(x, y, celda, celda, Color.SkyBlue);
    }
        Raylib.EndDrawing();
    }
    Raylib.CloseWindow();
    }
}
