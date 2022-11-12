using Raylib_cs;


class Gems: ColoredObject {
    
    public int Size { get; set; }
    // public Rectangle gemRectangle { get; set; }


    public Gems(Color color, int size): base(color) {
        Size = size;
        // gemRectangle = new Rectangle((int)Position.X, (int)Position.Y, 13, 15);
    }
    override public void Draw() {
        // Raylib.DrawRectangle((int)Position.X, (int)Position.Y, 13, 15, Color.BLUE);
        Raylib.DrawText("*", (int)Position.X, (int)Position.Y, Size, Color);
        // Raylib.DrawRectangleRec(gemRectangle, Color.BLUE);
    }
}


class Rocks: ColoredObject {
    public int Size { get; set; }

    public Rocks(Color color, int size): base(color) {
        Size = size;
        // var rockRectangle = new Rectangle((int)Position.X, (int)Position.Y, 13, 18);
    }
    override public void Draw() {
        // Raylib.DrawRectangle((int)Position.X, (int)Position.Y, 13, 18, Color.RED);
        Raylib.DrawText("0", (int)Position.X, (int)Position.Y, Size, Color);
    }
}