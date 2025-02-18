
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

#region Examples_2  !!!!

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





//Rect c = new Rect();
//c.Render();                             // 2

//Shape a = new Rect();
//a.Render();                             // 1

//IRenderable b = new Rect();
//b.Render();                             // 3

//interface IRenderable
//{
//    void Render();
//}

//class Shape: IRenderable
//{
//    public void Render() => Console.WriteLine("Render() from Shape");               // 1
//}
//class Rect: Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("Render() from Rect");            // 2
//    void IRenderable.Render() => Console.WriteLine("Explicit Render() from Rect");  // 3
//}

#endregion

#region Inheritance

//IWritable a = new FileManager();
//a.Write();

//IFileSaver b = new FileManager();
//b.Write();
//b.Save();


//interface IWritable
//{
//    // public void Write();
//    public void Write() => Console.WriteLine("Write() from IWritable");
//}

//interface IFileSaver: IWritable
//{
//    // public void Save();
//    public void Save() => Console.WriteLine("Save() from IFileSaver");
//    public new void Write() => Console.WriteLine("Write() from IFileSaver");
//}

//class FileManager : IFileSaver
//{
//    //public void Save()
//    //{
//    //    throw new NotImplementedException();
//    //}

//    //public void Write()
//    //{
//    //    throw new NotImplementedException();
//    //}
//}



//IWritable a = new FileManager();
//IFileSaver b = new FileManager();

//a.Write();      // 3
//b.Write();      // 3


//interface IWritable
//{
//    public void Write() => Console.WriteLine("Write() from IWritable");             // 1
//}

//interface IFileSaver : IWritable
//{
//    public new void Write() => Console.WriteLine("Write() from IFileSaver");       // 2
//}

//class FileManager : IFileSaver
//{
//    public void Write() => Console.WriteLine("Write() from FileManager");           // 3
//}

#endregion

#region Interfaces as constraints

//FileManager<File> fm = new FileManager<File>();
//fm.Process(new File("/bin/debug/log.txt"));

//// FileManager<Doc> fm2 = new FileManager<Doc>();       // ERROR

//interface IWritable
//{
//    public void Write();
//}
//interface ISavable
//{
//    string? Path { get; }
//}
//class File : IWritable, ISavable
//{
//    public string? Path { get; }
//    public File(string? path) => Path = path;

//    public void Write()
//    {
//        Console.WriteLine("File was written");
//    }
//}
//class Doc : IWritable
//{
//    public void Write()
//    {
//        Console.WriteLine("Document was written");
//    }
//}

//class FileManager<T>
//    where T : IWritable, ISavable
//{
//    public void Process(T data)
//    {
//        data.Write();
//        Console.WriteLine(data.Path);
//    }
//}

#endregion

#region Generic interfaces

//User<int> a = new User<int>(101);
//IAuth<int> b = a;

//Admin c = new Admin("102");
//IAuth<string> d = c;

//Author e = new Author("103");
//User<string> f = e;
//IAuth<string> g = e;

//interface IAuth<T>
//{
//    public T Id { get; }
//}

//class User<T> : IAuth<T>
//{
//    public T Id { get; }
//    public User(T id) => this.Id = id;
//}

//class Admin : IAuth<string>
//{
//    public string Id { get; }
//    public Admin(string id) => this.Id = id;
//}

//class Author : User<string>
//{
//    public Author(string id)
//        : base(id)
//    { }
//}

#endregion

#region IComparable

//List<User> users = new List<User>()
//{
//    new User() {Id = 101, Email = "email1@mail.com", Age = 43 },
//    new User() {Id = 102, Email = "email2@mail.com", Age = 21 },
//    new User() {Id = 103, Email = "email3@mail.com", Age = 32 },
//    new User() {Id = 104, Email = "email4@mail.com", Age = 20 },
//};

//users.Sort();

//foreach(User u in users)
//    Console.WriteLine(u);

//class User : IComparable
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }
//    public int CompareTo(object? obj)
//    {
//        if (obj is User u)
//        {
//            return Age - u.Age;
//        }

//        throw new ArgumentException();
//    }

//    public override string ToString()
//    {
//        return $"id: {Id} email: {Email} age: {Age}";
//    }
//}


//class User : IComparable<User>
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }
//    public int CompareTo(User? obj)
//    {
//        if (obj is null)
//            throw new ArgumentNullException(nameof(obj));

//        return Age - obj.Age;
//    }

//    public override string ToString()
//    {
//        return $"id: {Id} email: {Email} age: {Age}";
//    }
//}


#endregion

#region IComparer

//List<User> users = new List<User>()
//{
//    new User() {Id = 101, Email = "email1@mail.com", Age = 43 },
//    new User() {Id = 102, Email = "email2@mail.com", Age = 21 },
//    new User() {Id = 103, Email = "email3@mail.com", Age = 32 },
//    new User() {Id = 104, Email = "email4@mail.com", Age = 20 },
//};

//users.Sort(new UserIdComparer());
//foreach (User u in users)
//    Console.WriteLine(u);

//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }

//    public override string ToString()
//    {
//        return $"id: {Id} email: {Email} age: {Age}";
//    }
//}

//class UserAgeComparer : IComparer<User>
//{
//    public int Compare(User? x, User? y)
//    {
//        if (x == null || y == null)
//            return 0;

//        return x.Age - y.Age;
//    }
//}
//class UserIdComparer : IComparer<User>
//{
//    public int Compare(User? x, User? y)
//    {
//        if (x == null || y == null)
//            return 0;

//        return y.Id - x.Id;
//    }
//}

#endregion

#region ICloneable

//class User : ICloneable
//{
//    public object Clone()
//    {
//        throw new NotImplementedException();
//    }
//}


// BUNS
//MyList<int> a = new MyList<int>();

//MyList<int>? b = a.Clone() as MyList<int>;

//class MyList<T> : List<T>, ICloneable
//{
//    public object Clone()
//    {
//        throw new NotImplementedException();
//    }
//}

#endregion

#region Invarinace (as it is) / Covariance (up to types, out) / Contrvariance (down to types, in)

// --------------------------- Инвариантный обобщённый интерфейс ------------------------------

//MySqlManager a = new MySqlManager();

//IConnManager<MySqlConn> manager_0 = a;

//// IConnManager<Conn> manager_1 = a;           // ERROR

//class Conn
//{
//    public string? ConnString { get; set; }
//    public Conn(string? connString) => ConnString = connString;
//}
//class MySqlConn : Conn
//{
//    public MySqlConn(string? connString) : base(connString)
//    { }
//}

//interface IConnManager<T>
//{
//    T CreateConn(string? connString);
//}
//class MySqlManager : IConnManager<MySqlConn>
//{
//    public MySqlConn CreateConn(string? connString)
//    {
//        return new MySqlConn(connString);
//    }
//}


// ------------------------------------- Ковариантный обобщённый интерфейс --------------------------------------

//MySqlManager manager_0 = new MySqlManager();                            // invariance

//IConnactionManager<MySqlConnection> manager_1 = new MySqlManager();     // invariance

//IConnactionManager<Connection> manager_2 = manager_0;                   // <-- covariance !!!!
//Connection conn = manager_2.CreateConnection("config string");
//Console.WriteLine(conn.ConnString);


//IConnactionManager<Connection> manager = new MySqlManager();
//Connection conn2 = manager.CreateConnection("configs");
//Console.WriteLine(conn2.ConnString);


//List<IConnactionManager<Connection>> list = new List<IConnactionManager<Connection>>()
//{
//   new MySqlManager(),
//   new SqlServManager()
//};

//foreach (var m in list)
//    Console.WriteLine(m.CreateConnection("config").ConnString);



//class Connection
//{
//    public string? ConnString { get; set; }
//    public Connection(string? connString)
//    {
//        ConnString = connString;
//    }
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? connString) : base(connString)
//    { }
//}
//class SqlServConnection : Connection
//{
//    public SqlServConnection(string? connString) : base(connString)
//    { }
//}


//interface IConnactionManager<out T> // ковариантный обобщенный интерфейс (ковариантный универсальный параметр)
//{
//    T CreateConnection(string connString);
//}
//class MySqlManager : IConnactionManager<MySqlConnection>
//{
//    public MySqlConnection CreateConnection(string connString)
//    {
//        return new MySqlConnection(connString);
//    }
//}
//class SqlServManager : IConnactionManager<SqlServConnection>
//{
//    public SqlServConnection CreateConnection(string connString)
//    {
//        return new SqlServConnection(connString);
//    }
//}



// ------------------------------------- Контрвариантный обобщённый интерфейс --------------------------------------

//object m0 = new MySqlManager();                                 // <-- invariance

//MySqlManager m1 = new MySqlManager();                           // <-- invariance

//IConnactionManager<Connection> m2 = new MySqlManager();         // <-- invariance

//IConnactionManager<MySqlConnection> m3 = new MySqlManager();    // <-- contrvariance
//m3.SetConnection(new MySqlConnection("configs"));

//IConnactionManager<SqlServConnection> m4 = new SqlServManager();
//m4.SetConnection(new SqlServConnection("sql serv config"));



//class Connection
//{
//    public string? ConnString { get; set; }
//    public Connection(string? connString)
//    {
//        ConnString = connString;
//    }
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? connString) : base(connString)
//    { }
//}
//class SqlServConnection : Connection
//{
//    public SqlServConnection(string? connString) : base(connString)
//    { }
//}


//interface IConnactionManager<in T> // контрвариантный обобщенный интерфейс (контрвариантный универсальный параметр)
//{
//    public void SetConnection(T conn);
//}

//class MySqlManager : IConnactionManager<Connection>
//{
//    public void SetConnection(Connection conn)
//    {
//        Console.WriteLine($"MySqlManager: {conn.ConnString}");
//    }
//}

//class SqlServManager : IConnactionManager<Connection>
//{
//    public void SetConnection(Connection conn)
//    {
//        Console.WriteLine($"SqlServManager: {conn.ConnString}");
//    }
//}



// ------------- совместное использовани --------


//ILogger<A, B> a = new FileLogger();

//ILogger<A, A> b = new FileLogger();

//ILogger<B, A> c = new FileLogger();


//class A
//{

//}
//class B : A
//{

//}


//interface ILogger<in T, out K>
//{
//    void Log(T val);
//    K SendMessage(string mes);
//}


//class FileLogger : ILogger<A, B>
//{
//    public void Log(A val)
//    {
//        throw new NotImplementedException();
//    }

//    public B SendMessage(string mes)
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion

#region Extra
//Manager x = new Manager();
//IComparable<A> y = x;
//IComparable<B> z = x;

//class A
//{}

//class B: A
//{ }


//class Manager : IComparable<A>
//{
//    public int CompareTo(A? other)
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion
