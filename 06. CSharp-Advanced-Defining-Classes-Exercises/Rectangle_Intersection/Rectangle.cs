public class Rectangle
{
    private string id;
    private int width;
    private int height;
    private int startCoordinateX;
    private int startCoordinateY;
    private int endCoordinateX;
    private int endCoordinateY;
    private Rectangle itersectRectangle;

    public Rectangle(string id,int width, int height, int startCoordinateX, int endCoordinateY)
    {
        this.StartCoordinateX = startCoordinateX;
        this.StartCoordinateY = endCoordinateY - height;
        this.Width = width;
        this.Height = height;
        this.endCoordinateX = startCoordinateX + width;
        this.endCoordinateY = endCoordinateY;
    }

    public Rectangle ItersectRectangle
    {
        get { return this.itersectRectangle; }
        set { this.itersectRectangle = value; }
    }

    public int StartCoordinateY
    {
        get { return this.startCoordinateY; }
        set { this.startCoordinateY = value; }
    }

    public int StartCoordinateX
    {
        get { return this.startCoordinateX; }
        set { this.startCoordinateX = value; }
    }



    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public int Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }

    public bool CheckIntersect(Rectangle itersectRectangle)
    {
        this.ItersectRectangle = itersectRectangle;
        if (this.itersectRectangle.startCoordinateX >=startCoordinateX &&
            this.itersectRectangle.startCoordinateX <= endCoordinateX)
        {
            if (this.itersectRectangle.startCoordinateY >= startCoordinateY &&
                this.itersectRectangle.startCoordinateY <= endCoordinateY)
            {
                return true;
            }
            else if(this.itersectRectangle.endCoordinateY >= startCoordinateY &&
                this.itersectRectangle.endCoordinateY <= endCoordinateY)
            {
                return true;
            }
        }
        return false;
    }
}
