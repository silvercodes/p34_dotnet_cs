
//TextBox tb0 = new TextBox(150, 60);
//tb0.Render();

//IRenderable tb1 = new TextBox(150, 60);
//tb1.Render();

//IRenderable tb2 = new TextBox(150, 60);
//IRenderable dec0 = new BorderDecorator(tb2);
//dec0.Render();

//IRenderable tb2 = new TextBox(150, 60);
//IRenderable dec0 = new BorderDecorator(tb2, 3);
//IRenderable dec1 = new ColoredDecorator(dec0);
//dec1.Render();


//IRenderable tb = new ScrollDecorator(new ColoredDecorator(new BorderDecorator(new TextBox(160, 70), 5)));
//tb.Render();


//abstract class IRenderable
//{
//    public abstract void Render();
//}

//class TextBox: IRenderable
//{
//    private int W { get; set; }
//    private int H { get; set; }
//    public TextBox(int w, int h)
//    {
//        W = w;
//        H = h;
//    }
//    public override void Render()
//    {
//        Console.WriteLine($"TextBox: W: {W}, H: {H}");
//    }
//}

//class Decorator: IRenderable
//{
//    private IRenderable Item { get; set; }
//    public Decorator(IRenderable item)
//    {
//        Item = item;
//    }
//    public override void Render()
//    {
//        Item.Render();
//    }
//}
//class BorderDecorator: Decorator
//{
//    private int thikness;
//    public BorderDecorator(IRenderable item, int thikness):
//        base(item)
//    { 
//        this.thikness = thikness;
//    }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine($"Border {thikness} px");
//    }
//}
//class ColoredDecorator : Decorator
//{
//    public ColoredDecorator(IRenderable item) :
//        base(item)
//    { }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine("Colored");
//    }
//}
//class ScrollDecorator: Decorator
//{
//    public ScrollDecorator(IRenderable item) :
//        base(item)
//    { }
//    public override void Render()
//    {
//        base.Render();
//        Console.WriteLine("Scrolled");
//    }
//}


#region Task
// Написать мини-приложение для пиццерии на основе паттерна Decorator
// 1. Пицца может 3-х разных размеров
// 2. Пицца имеет название
// 3. Возможные ингридиенты: помидоры, сыр, грибы, сырный бортик ...
// Функционал: 
//			создать любую пиццу из ингридиентов, 
//			узнать стоимость пиццы
//			напечатать чек (состав + стоимость)




#endregion