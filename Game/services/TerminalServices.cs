
using Raylib_cs;
using System.Numerics;

class TerminalServices {
  

    public void createBackground() {

        int score = 0;

        var ScreenHeight = 480;
        var ScreenWidth = 800;
        var RectangleSize = 50;      

        var PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
        // var PlayerSquare = new 
        // var MovementSpeed = 10;

        var position = new Vector2(ScreenWidth / 2, ScreenHeight - 2);

        var player = new PlayerIcon(ScreenWidth / 2, ScreenHeight - 2, Color.GREEN, 10);
        player.Position = position; 
        var playerMovementSpeed = 10;
        // player.Velocity = new Vector2(random)
        

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);


        while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawText($"Score: {score}", 10, 2, 15, Color.WHITE);


                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    player.x += playerMovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    player.x -= playerMovementSpeed;
                }

        
                Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

        //         if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
        

        // We'll be checking for collisions with the rocks and gems, and with conditional statements determine what happens to the score. 

                Raylib.EndDrawing();
            }
            
            Raylib.CloseWindow();
    }
}