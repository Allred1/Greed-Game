using Raylib_cs;
using System.Numerics;


class GameObject {
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);


    // drawing
    virtual public void Draw() {
        // Base game objects do not have anything to draw
    }


    // movement 
    public void Move() {
        // var MovementSpeed = 10;
        Vector2 NewPosition = this.Position;
        NewPosition.X += Velocity.X;
        NewPosition.Y += Velocity.Y;
        Position = NewPosition;

        // if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) {
        //     NewPosition.X += MovementSpeed;
        // }

        // if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) {
        //     NewPosition.X -= MovementSpeed;
        // }
    }

    


    // color
    public Color Color { get; set; }
    public void ColoredObject(Color color) {
        Color = color;
    }    
}