using Raylib_cs;


// player inherits object class
// this creates the "#" player symbol to move
class PlayerIcon: ColoredObject {

    public int Size { get; set; }

    public PlayerIcon(Color color, int size): base(color) {
        Size = size;        
    }

    override public void Draw() {
    }
}