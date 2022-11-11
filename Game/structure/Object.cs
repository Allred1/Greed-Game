using Raylib_cs;
using System.Numerics;


class ObjectClass {
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
    }
}


class ColoredObject: ObjectClass {
    // color
    public Color Color { get; set; }
    public ColoredObject(Color color) {
        Color = color;
    }    
}

//     // color
//     public Color Color { get; set; }
//     public Color(Color color) {
//         Color = color;
//     }    
// }