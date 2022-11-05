using Raylib_cs;


// player inherits object class
// this creates the "#" player symbol to move
class PlayerIcon: GameObject {

    public int Size { get; set; }

    public PlayerIcon(float x, float y, Color color, int size) {
        Size = size;        
    }

    override public void Draw() {
        Raylib.DrawText("#", (int)Position.X, (int)Position.Y, Size, Color);
    }
}