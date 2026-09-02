using Raylib_cs;

Raylib.InitWindow(800, 600, "Ventana Gráfica");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);

    Raylib.DrawText("¡Hola, mundo!", 190, 200, 20, Color.Maroon);

    Raylib.EndDrawing();
}
Raylib.CloseWindow();
