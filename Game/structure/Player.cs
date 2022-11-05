using Raylib_cs;


// player inherits object class
// this creates the "#" player symbol to move
class Player: Object {

    public int Size { get; set; }

    public void GameText(Color color, int size) {
        Size = size;        
    }

    override public void Draw() {
        Raylib.DrawText("#", (int)Position.X, (int)Position.Y, Size, Color);
    }
}