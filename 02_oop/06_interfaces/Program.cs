
#region Intro
//ILogger a = new FileLogger();
//interface ILogger
//{}
//class FileLogger : ILogger
//{}


//interface IRenderable { }
//interface IMovable { }
//interface ILogger { }
//interface IShape { }


// Может содержать
// 1. Methods
// 2. Properties
// 3. Events
// 4. Indexators
// 5. Static (const)

//interface IRenderable
//{
//    public static int count = 0;
//    public int Level { get; set; }
//    public int Ration { get => 0; }
//    public void Render();
//    public void Info()
//    {
//        Console.WriteLine("Info()");
//    }
//}

#endregion

#region Examples_1

//Unit a = new Unit();
//a.Render();
//IRenderable b = new Unit();
//b.Render();

//IRenderable c = new Unit();
//c.WriteLogs();
//IRenderable d = new Mesh();
//d.WriteLogs();
//Mesh e = new Mesh();
//// e.WriteLogs();               // ERROR


//interface IRenderable
//{
//    public void Render();
//    public void WriteLogs()
//    {
//        Console.WriteLine("IRenderable logs...");
//    }
//}

//class Unit : IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Unit.Render()");
//    }
//    public void WriteLogs()
//    {
//        Console.WriteLine("Unit logs...");
//    }

//}

//class Mesh: IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Mesh.Render()");
//    }
//}

#endregion

#region Multiple implementation

//Db db = new Db();

//IWritable a = db;
//a.Write();
//IComparable b = db;
//b.Compare(a);

//IWritable a = new Db();
//if (a is Db c)
//{
//    c.Save();
//}

//interface IWritable
//{
//    public void Write();
//}

//interface IComparable
//{
//    public bool Compare(object? obj);
//}

//class Db : IWritable, IComparable
//{
//    public bool Compare(object? obj)
//    {
//        return true;
//    }
//    public void Write()
//    {
//        Console.WriteLine("Write to File");
//    }
//    public void Save()
//    {
//        Console.WriteLine("Save to db...");
//    }
//}

#endregion

#region Explicit / implicit realization

//Db db = new Db();
//// db.Write();                 // ERROR

//IWritable a = db;
//a.Write();
//ISaver b = db;
//b.Write();


//Db db = new Db();
//((IWritable)db).Write();        // :-(

//if (db is IWritable wdb)        // :-)
//    wdb.Write();

//IWritable w = db;               // :-)


//interface IWritable
//{
//    public void Write();
//}
//interface ISaver
//{
//    public void Write();
//}

//class Db: IWritable, ISaver
//{
//    public string Config { get; set; } = "config string";

//    // ==== Общая реализация (неявная(обычная) реализация) для всех интерфейсов ===
//    //public void Write()
//    //{
//    //    Console.WriteLine("Common realization");
//    //}


//    // === Явная реализация (отдельно для каждого интерфейса)
//    // Методы НЕ ЯВЛЯЮТСЯ ЧЛЕНАМИ КЛАССА!
//    // Нельзя использовать модификаторы
//    void IWritable.Write()
//    {
//        Console.WriteLine(Config);
//        Console.WriteLine("IWritable.Write() from Db");
//    }
//    void ISaver.Write()
//    {
//        Console.WriteLine(Config);
//        Console.WriteLine("ISaver.Write() from Db");
//    }
//}

//class FileManager : IWritable
//{
//    void IWritable.Write()
//    {
//        Console.WriteLine("FileManager.Write()");
//    }
//}






//FileManager a = new FileManager();
//a.Write();
//ISaver b = new FileManager();
//b.Write();

//interface ISaver
//{
//    public void Write();
//}
//class FileManager : ISaver
//{
//    public void Write()
//    {
//        Console.WriteLine("FileManager.Write()");
//    }

//    void ISaver.Write()
//    {
//        Console.WriteLine("FileManager.ISaver.Write()");
//    }
//}


#endregion

#region Examples_2

//interface IRenderable
//{
//    public void Render();
//    public void Calc();
//    public void Update();
//}

//abstract class Shape: IRenderable
//{
//    public abstract void Render();

//    public virtual void Calc()
//    {
//        Console.WriteLine("Calc() from Shape");
//    }
//    public void Update()
//    {
//        Console.WriteLine("Update() from Shape");
//    }
//}

//class Rect : Shape
//{
//    public override void Render()
//    {
//        Console.WriteLine("Render() from Rect");
//    }

//    public override void Calc()
//    {
//        Console.WriteLine("Calc() from Rect");
//    }
//    public new void Update()
//    {
//        Console.WriteLine("Update() from Rect");
//    }
//}





// ===== Повторная реализация интерфейса ======

//Shape a = new Rect();
//a.Render();                 // Render() from Shape

//IRenderable b = new Rect();
//b.Render();

//Rect c = new Rect();
//c.Render();


//interface IRenderable
//{
//    public void Render();
//}

//class Shape : IRenderable
//{
//    public void Render() => Console.WriteLine("Render() from Shape");
//}

//class Rect: Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("Render() from Rect");
//}





Rect c = new Rect();
c.Render();                             // 2

Shape a = new Rect();
a.Render();                             // 1

IRenderable b = new Rect();
b.Render();                             // 3

interface IRenderable
{
    void Render();
}

class Shape: IRenderable
{
    public void Render() => Console.WriteLine("Render() from Shape");               // 1
}
class Rect: Shape, IRenderable
{
    public new void Render() => Console.WriteLine("Render() from Rect");            // 2
    void IRenderable.Render() => Console.WriteLine("Explicit Render() from Rect");  // 3
}

#endregion





