using Raylib_cs;


class Gems: ObjectClass {
    
    public int Size { get; set; }

    public Gems(Color color, int size) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawText("*", (int)Position.X, (int)Position.Y, Size, Color);
    }
}


class Rocks: ObjectClass {
    public int Size { get; set; }

    public Rocks(Color color, int size) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawText("0", (int)Position.X, (int)Position.Y, Size, Color);
    }
}