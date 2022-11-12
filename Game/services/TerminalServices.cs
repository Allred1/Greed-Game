
using Raylib_cs;
using System.Numerics;

class TerminalServices {

    public void createBackground() {


        var ScreenHeight = 480;
        var ScreenWidth = 800;
        var Objects = new List<ObjectClass>();
        var Masks = new List<Raylib_cs.Rectangle>();
        int score = 0;
        var Random = new Random();
        var timerCounter = 0;



        // configure the player icon
        var playerPosition = new Vector2(ScreenWidth / 2, ScreenHeight - 45);
        var MovementSpeed = 8;


        Raylib.InitWindow(ScreenWidth, ScreenHeight, "Greed");
        Raylib.SetTargetFPS(60);


        while (!Raylib.WindowShouldClose())
        {            
            // Randomly add gems and rocks objects
            var whichType = Random.Next(2);
            // Random velocity for gems and rocks
            var randomY = Random.Next(3);
            var randomX = Random.Next(0);

            
            // start at the top of the screen
            var startAtTop = ScreenHeight - ScreenHeight - 30;
            var position = new Vector2(Random.Next(ScreenWidth), startAtTop);
            
            timerCounter += 1;

            switch (whichType) {
                case 0: 
                    if (timerCounter == 10) {
                        Console.WriteLine("Creating a gem");
                        var gem = new Gems(Color.WHITE, 25);
                        gem.Position = position;
                        gem.Velocity = new Vector2(randomX, randomY);
                        gem.isGem = true;
                        Objects.Add(gem);
                        timerCounter = 0;
                    }
                    break;
                case 1: 
                    if (timerCounter == 10) {
                        Console.WriteLine("Creating a rock");
                        var rock = new Rocks(Color.WHITE, 25);
                        rock.Position = position;
                        rock.Velocity = new Vector2(randomX, randomY);
                        rock.isGem = false;
                        Objects.Add(rock);
                        timerCounter = 0;
                    }
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
            foreach (var obj in Objects.ToList()) {
                obj.Draw();
            }
            
            Raylib.EndDrawing();

            // move the positions of the objects
            foreach (var obj in Objects) {
                obj.Move();
            }
            
            
            // Remove the objects as they pass beyond a certain y-value
            foreach (var obj in Objects.ToList()) {
                if (obj.Position.Y >= 475) {
                    Objects.Remove(obj);
                }
            }


            var playerRectangle = new Rectangle(playerPosition.X - 1, playerPosition.Y + 1, 14, 16);
            // check for collisions
            foreach (var obj in Objects.ToList()) {
                var rectanglePosition = new Rectangle(obj.Position.X, obj.Position.Y, 25, 25);
                // check collision of objects
                if (Raylib.CheckCollisionRecs(rectanglePosition, playerRectangle)) {
                    // if gem, add score (else (rock): subtract score)
                    if (obj.isGem == true) {
                        score += 1;
                    } else {
                        score -= 1;
                    }
                    Objects.Remove(obj);
                }
            }
        
    
            // draw the Player         
            // Raylib.DrawRectangle((int)playerRectangle.x, (int)playerRectangle.y, (int)playerRectangle.width, (int)playerRectangle.height, Color.GREEN);
            Raylib.DrawText("#", (int)playerPosition.X, (int)playerPosition.Y, 20, Color.WHITE);
        }
        Raylib.CloseWindow();
    }
}