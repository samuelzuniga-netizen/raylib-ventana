using System.Runtime.Serialization;
using Raylib_cs;

namespace S079PixelLab;

internal static class Program
{
    public static void Main(){
    const int anchoVentana = 800;
    const int altoVentana = 600;
    const int celda = 30;
    const int origenX = 100;
    const int origenY = 50;

    Raylib.InitWindow(anchoVentana, altoVentana, "Pixcel lab 16x16");
    Raylib.SetTargetFPS(60);

    while (!Raylib.WindowShouldClose())
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RayWhite);
        int[,] imagen = {
        {0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
        {0, 1, 2, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0},
        {0, 1, 1, 2, 1, 0, 0, 0, 0, 0, 0, 1, 2, 1, 0, 0},
        {0, 0, 1, 2, 2, 1, 1, 1, 1, 1, 0, 1, 2, 1, 0, 0},
        {0, 0, 1, 1, 1, 1, 2, 2, 2, 1, 1, 1, 2, 1, 0, 0},
        {0, 0, 0, 1, 1, 2, 2, 2, 2, 2, 1, 1, 2, 1, 0, 0},
        {0, 0, 0, 1, 2, 2, 1, 2, 2, 1, 2, 2, 1, 0, 0, 0},
        {0, 0, 0, 1, 3, 2, 2, 2, 2, 2, 2, 3, 1, 0, 0, 0},
        {0, 0, 0, 1, 2, 2, 1, 1, 1, 1, 2, 2, 1, 0, 0, 0},
        {0, 0, 0, 1, 2, 2, 1, 2, 2, 1, 2, 2, 1, 0, 0, 0},
        {0, 0, 0, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 0, 0, 0},
        {0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0},
        {0, 0, 0, 0, 0, 1, 2, 2, 2, 2, 2, 1, 1, 0, 0, 0},
        {0, 0, 0, 0, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 0, 0},
        {0, 0, 0, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 1, 1, 0},
       
    };

    for (int fila = 0; fila < 16; fila++)
    for (int col = 0; col < 16; col++)
    {
        int x = origenX + col * celda;
        int y = origenY + fila * celda;
        if (imagen[fila, col] == 1)
        Raylib.DrawRectangle(x, y, celda, celda, Color.Black);
        else if (imagen[fila, col] == 2)
        Raylib.DrawRectangle(x, y, celda, celda, Color.Yellow);
        else if(imagen[fila, col] == 3)
        Raylib.DrawRectangle(x, y, celda, celda, Color.Red);
    }
        Raylib.EndDrawing();
    }
    Raylib.CloseWindow();
    }
}
