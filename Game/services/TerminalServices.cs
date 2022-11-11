
using Raylib_cs;
using System.Numerics;

class TerminalServices {
  

    public void createBackground() {


        var ScreenHeight = 480;
        var ScreenWidth = 800;
        var Objects = new List<ObjectClass>();
        int score = 0;
        var Random = new Random();


        // configure the player icon
        var playerPosition = new Vector2(ScreenWidth / 2, ScreenHeight - 30);
        var MovementSpeed = 10;
        

        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);


        while (!Raylib.WindowShouldClose())
        {
            // make a list of colors
            var colorsList = new List<ColoredObject>();
            
            // Randomly add gems and rocks objects
            var whichType = Random.Next(2);
            // Random velocity for gems and rocks
            var randomY = Random.Next(3);
            var randomX = Random.Next(0);
            
            // start at the top of the screen
            var startAtTop = ScreenHeight - ScreenHeight - 30;
            var position = new Vector2(Random.Next(ScreenWidth), startAtTop);
            

            switch (whichType) {
                case 0: 
                    Console.WriteLine("Creating a gem");
                    var gem = new Gems(Color.RED, 25);
                    gem.Position = position;
                    gem.Velocity = new Vector2(randomX, randomY);
                    Objects.Add(gem);
                    break;
                case 1: 
                    Console.WriteLine("Creating a rock");
                    var rock = new Rocks(Color.WHITE, 25);
                    rock.Position = position;
                    rock.Velocity = new Vector2(randomX, randomY);
                    Objects.Add(rock);
                    break;
                default:
                    break;
            }


            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            Raylib.DrawText($"Score: {score}", 20, 2, 15, Color.WHITE);   


            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
                playerPosition.X += MovementSpeed;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
                playerPosition.X -= MovementSpeed;
            }


            // begin the drawings of each of the objects
            foreach (var obj in Objects) {
                obj.Draw();
            }

            Raylib.EndDrawing();

            // move the positions of the objects
            foreach (var obj in Objects) {
                obj.Move();
            }
            
            // Remove the objects as they pass beyond a certain y-value
            foreach (var obj in Objects.ToList()) {
                if (obj.Position.Y >= 460) {
                    Objects.Remove(obj);
                }
            }

            // i think this is adding a score-point for every point of every object the rectangle touches. This will have to be fixed.             
            // foreach (var rock in Objects.ToList()) {
            //     if (Raylib.CheckCollisionPointRec(rock.Position, PlayerRectangle)) {
            //         score -= 1;
            //         Objects.Remove(rock);
            //     }
            // }    
            // foreach (var gem in Objects.ToList()) {
            //     if (Raylib.CheckCollisionPointRec(gem.Position, PlayerRectangle)) {
            //         score += 1;
            //         Objects.Remove(gem);
            //     }
            // }         

    
            // draw the Player         
            Raylib.DrawText("#", (int)playerPosition.X, (int)playerPosition.Y, 25, Color.WHITE);
            


            // We'll be checking for collisions with the rocks and gems, and with conditional statements determine what happens to the score.    

            // timer function will be helpful in ditributing the rocks and gems evenly and slowly
        }

        Raylib.CloseWindow();
    }
}