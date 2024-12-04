namespace _00_class;

internal class Unit
{
    public string title;
    public Point position;
    public Unit(string title, Point position)
    {
        this.title = title;
        this.position = position;
    }
    public void Deconstruct(out string unitTitle, out Point unitPosition)
    {
        unitTitle = title;
        unitPosition = position;
    }
}
