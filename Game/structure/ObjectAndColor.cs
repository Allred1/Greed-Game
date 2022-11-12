using Raylib_cs;
using System.Numerics;




class ObjectClass {
    public Vector2 Position { get; set; } = new Vector2(0, 0);
    public Vector2 Velocity { get; set; } = new Vector2(0, 0);

    // 
    public bool isGem;

    virtual public void Draw() {
    }

    // movement 
    public void Move() {
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

        Color getRandomColor() {
            // make a list of colors
            var colorsList = new List<Raylib_cs.Color>();
            // add individually raylib colors ("Color.BLUE")
            colorsList.Add(Color.RED);
            colorsList.Add(Color.MAGENTA);
            colorsList.Add(Color.YELLOW);
            colorsList.Add(Color.GREEN);
            colorsList.Add(Color.LIME);
            colorsList.Add(Color.SKYBLUE);
            colorsList.Add(Color.BLUE);
            colorsList.Add(Color.VIOLET);
            colorsList.Add(Color.WHITE);

            var random = new Random();
            var randomColorIndex = random.Next(colorsList.Count);
            var randomColor = colorsList[randomColorIndex];
            return randomColor;
        }

        Color = getRandomColor();
    }    
}
