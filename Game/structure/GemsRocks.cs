using Raylib_cs;


class Gems: ColoredObject {
    
    public int Size { get; set; }

    public Gems(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawText("*", (int)Position.X, (int)Position.Y, Size, Color);
    }
}


class Rocks: ColoredObject {
    public int Size { get; set; }

    public Rocks(Color color, int size): base(color) {
        Size = size;
    }

    override public void Draw() {
        Raylib.DrawText("0", (int)Position.X, (int)Position.Y, Size, Color);
    }
}