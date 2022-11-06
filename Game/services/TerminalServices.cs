
using Raylib_cs;
using System.Numerics;

class TerminalServices {
  

    public void createBackground() {

        int score = 0;

        var ScreenHeight = 480;
        var ScreenWidth = 800;
        // var RectangleSize = 50;      

        // var PlayerRectangle = new Rectangle(ScreenWidth - (RectangleSize * 2), ScreenHeight - (RectangleSize * 2), RectangleSize, RectangleSize);
        // var PlayerSquare = new 
        // var MovementSpeed = 10;




        // var position = new Vector2((ScreenWidth / 2), (ScreenHeight - 2));
        // var player = new PlayerIcon(Color.WHITE, 50);
        // player.Position = position; 
        var playerMovementSpeed = 10;
        
        // player.Velocity = new Vector2(random)
        var Objects = new List<GameObject>();
        var Random = new Random();
        var randomY = Random.Next(2);
        var randomX = Random.Next(0);


        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);

       


        while (!Raylib.WindowShouldClose())
            {

                var startAtTop = ScreenHeight - ScreenHeight;
                var position = new Vector2(ScreenWidth / 2, ScreenHeight - 2);

                var text = new PlayerIcon(Color.WHITE, 50);
                text.Position = position;
                text.Velocity = new Vector2(randomX, randomY);
                Objects.Add(text);

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);


                Raylib.DrawText($"Score: {score}", 20, 2, 15, Color.WHITE);                

                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                    position.X += playerMovementSpeed;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                    position.X -= playerMovementSpeed;
                }

                text.Draw();
        
                // Raylib.DrawRectangleRec(PlayerRectangle, Color.RED);

                // if (Raylib.CheckCollisionRecs(PlayerRectangle, TargetRectangle)) {

                foreach (var obj in Objects) {
                    obj.Draw();
                }

                Raylib.EndDrawing();

                foreach (var obj in Objects) {
                    obj.Move();
                }
            
        
        // We'll be checking for collisions with the rocks and gems, and with conditional statements determine what happens to the score. 

                
            }
            
            Raylib.CloseWindow();
    }
}