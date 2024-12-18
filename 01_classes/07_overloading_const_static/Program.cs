
#region Methods overloading
// Имя методов одинаковое
// Другое кол-во параметров
// Другой порядок типов параметров
// Другие типы параметров
// Другие модификаторы параметров (in / out ...)

//class Container
//{
//    public void Method(int a, int b)
//    { }

//    //public int Method(int a, int b)       // ERROR
//    //{ }

//    public void Method(int a, int b, int c)
//    { }

//    public void Method(double a, int b)
//    { }

//    public void Method(int a, double b)
//    { }

//    public void Method(ref int a, int b)
//    { }
//}

#endregion

#region static

//User a = new();
//User b = new();
//a.Render();
//b.Render();
//Console.WriteLine(User.maxId);

//Console.WriteLine(Counter.Add(3, 4));

//class User
//{
//    public static int maxId = 0;
//    public int id;
//    public User()
//    {
//        id = ++User.maxId;
//    }
//    static User()
//    {
//        User.MaxId = 0;
//    }
//    public static void ResetMaxId() => User.maxId = 0;
//    public static int MaxId
//    {
//        get => User.maxId;
//        set => User.maxId = value;
//    }
//    public static int Count { get; set; }


//    public void Render()
//    {
//        Console.WriteLine($"id: {id}");
//    }
//}

//static class Counter
//{
//    public static int Add(int a, int b) => a + b;
//    //public void Method()
//    //{ }
//}

#endregion

#region const / readonly field / readonly struct

Console.WriteLine(User.DefaultRole);

User a = new User();
// a.DefaultName = "petya";     // ERROR
Console.WriteLine(a.DefaultName);

class User
{
    // ~~~ static (не является частью состояния объекта)
    public const string DefaultRole = "guest";

    // ~~~ является частью состояния объекта
    public readonly string DefaultName = "no_name";         // case 1
    public User()
    {
        DefaultName = "vasia";                              // case 2
    }
}

readonly struct Shape
{
    public readonly int id;
    public int Size { get; }
    public string Title { get; init; }
    public Shape(int size, string titile)
    {
        Size = size;
        Title = titile;
    }
}

#endregion



