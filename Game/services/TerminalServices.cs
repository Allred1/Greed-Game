
using Raylib_cs;

class TerminalServices {

    Player player = new Player();
    


    public void createBackground() {

        var ScreenHeight = 480;
        var ScreenWidth = 800;
        var RectangleSize = 50;

        var PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
        // var TargetRectangle = new Rectangle(100, 100, RectangleSize, RectangleSize);
        var MovementSpeed = 10;

        // testing rock drawing
        // void DrawRectangleLines(int posX, int posY, int width, int height, Color color);

        

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);




        while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

        //         Raylib.DrawText("Move the red square to the blue square with the arrow keys!", 12, 12, 20, Color.BLACK);
    



                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    PlayerRectangle.x += MovementSpeed;
                }

                // if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                //     player.Draw().x += MovementSpeed;
                // }

                // if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                //     PlayerRectangle.x -= MovementSpeed;
                // }


                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    PlayerRectangle.x -= MovementSpeed;
                }

               


    //  no need for "up/down" keys to move the player icon
                // if (Raylib.IsKeyDown(KeyboardKey.KEY_UP)) {
                //     PlayerRectangle.y -= MovementSpeed;
                // }

                // if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) {
                //     PlayerRectangle.y += MovementSpeed;
                // }

        //         Raylib.DrawRectangleRec(TargetRectangle, Color.BLUE);
                Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

        //         if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {
        //             Raylib.DrawText("You did it!!!!", 12, 34, 20, Color.BLACK);
        //         }

        // We'll be checking for collisions with the rocks and gems, and with conditional statements determine what happens to the score. 

                Raylib.EndDrawing();
            }
            
            Raylib.CloseWindow();
    }
}