
//Point p = new Point();
//p.x = 10;
//p.y = 10;

//Point a = new Point();
//a.Render();

//Point b = new Point(3, 4);
//b.Render();

Point a = new Point()
{ 
    x = 2,
    y = 2,
};

Point b = a;
Point c = b with { y = 200 };



struct Point
{
    public int x = 3;
    public int y = 3;

    public Point()
    {
        x = 10;
    }

    //public Point()
    //{
    //    x = 2;
    //    y = 2;
    //}
    //public Point(int x, int y)
    //{
    //    this.x = x;
    //    this.y = y;
    //}
    public void Render()
    {
        Console.WriteLine($"x: {x}, y: {y}");
    }

}

