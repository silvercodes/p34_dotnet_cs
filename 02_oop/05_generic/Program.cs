
#region Generics

//User user1 = new()
//{
//    Id = 101,
//    Email = "vasia@mail.com",
//};

//User user2 = new()
//{
//    Id = "9we-weuroi",
//    Email = "vasia@mail.com",
//};

//int id1 = (int)user1.Id;
//int id2 = (int)user2.Id;

//class User
//{
//    public object Id { get; set; }
//    public string Email { get; set; }
//}







//User<int> user1 = new User<int>()
//{
//    Id = 101,
//    Email = "vasia@mail.com",
//};

//User<string> user2 = new User<string>()
//{
//    Id = "101",
//    Email = "vasia@mail.com",
//};

//class User<T>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//}






//User<int, string> user = new User<int, string>(101, "vasia@mail.com");

//class Role<T>
//{
//    public T Id { get; set; }
//}

//class User<T, K>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//    public Role<K> Role { get; set; }
//    public User(T id, string email)
//    {
//        Id = id;
//        Email = email;
//    }
//}





//User<int, Role<string>> user = new User<int, Role<string>>(101, "vasia@mail.com");

//class Role<T>
//{
//    public T Id { get; set; }
//}

//class User<T, K>
//{
//    public T Id { get; set; }
//    public string Email { get; set; }
//    public K Role { get; set; }
//    public User(T id, string email)
//    {
//        Id = id;
//        Email = email;
//    }
//}




//Unit<int, Backpack<int, BackpackLevel>, Point<double>> unit = new Unit<int, Backpack<int, BackpackLevel>, Point<double>>();

//enum BackpackLevel
//{
//    Top,
//    Middle,
//    Low
//}
//class Point<T>
//{
//    public T X { get; set; }
//    public T Y { get; set; }
//}
//class Backpack<T, P>
//{
//    public T Id { get; set; }
//    public P Level { get; set; }
//}

//class Unit<T, B, P>
//{
//    public T Id { get; set; }
//    public B Backpack { get; set; }
//    public P Position { get; set; }
//}

#endregion

#region Static

//User<int> a = new()
//{
//    Id = 101,
//    Email = "vasia@mail.com",
//};

//User<string> b = new()
//{
//    Id = "102",
//    Email = "petya@mail.com",
//};

//User<int>.maxId = 101;
//User<string>.maxId = "202";
//Console.WriteLine(User<int>.maxId);
//Console.WriteLine(User<string>.maxId);

//User<string> c = new()
//{
//    Id = "104",
//    Email = "dima@mail.com",
//};


//class User<T>
//{
//    public static T maxId;
//    public T Id { get; set; }
//    public string Email { get; set; }
//}

#endregion

#region Generic methods

//Logger.Analyse<int>(45);
//Logger.Analyse<Entry>(new Entry() { Data = "Info from Entry" });


//class Entry
//{
//    public string Data { get; set; }
//    public override string ToString()
//    {
//        return $"DATA: {Data}";
//    }
//}

//class Logger
//{
//    //
//    //

//    public static void Analyse<T>(T entry)
//    {
//        Console.WriteLine(entry);
//    }
//}

#endregion

#region Task_1

// Написать обобщенный класс Container
// Хранить данные в массиве
// Методы:
//          Добавление
//          Удаление
//          Получение по индексу
// Свойства
//          Длина хранилища

#endregion

#region Generic methods constraints

//Renderer.Render<Archer>(new Archer(110));

//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp) => Hp = hp;
//}

//class Archer : Unit
//{
//    public Archer(int hp) :
//        base(hp)
//    { }
//}

//class Warrior: Unit
//{
//    public Warrior(int hp) :
//        base(hp)
//    { }
//}

//class Renderer
//{
//    public static void Render<T>(T obj)
//        where T : Unit
//    {
//        Console.WriteLine(obj.Hp);
//    }
//}

#endregion

#region Generic types constraints

// _1_
// concrete class
// or
// class
// or
// struct

// _2_
// concrete interfaces

// _3_
// new()                // T - тип, который имеет конструктор по-умолчанию без параметров

//class Logger<T>
//    where T : _1_, _2_, _3_ 
//{
//
//}


//Logger<Document> logger = new Logger<Document>();

//class Document
//{
//    public int Id { get; set; }
//    public Document()
//    { }
//    public Document(int id)
//    {
//        Id = id;
//    }
//}

//class Logger<T>
//    // where T : class, new()
//    where T : Document, new()
//{
//    public void Execute()
//    {
//        T a = new T();
//    }
//}

//class Compressor<T, K>
//    where T : class
//    where K : Logger<Document>
//{

//}

#endregion

#region Inheritance

//Archer<int, string> a = new Archer<int, string>(101);
//Unit<int> b = new Archer<int, string>(101);

//class Role
//{}
//class Unit<T>
//    where T : new()
//{
//    public T Id { get; set; }
//    public Unit(T id) => Id = id;
//}

// 1. Наследник с тем же типом
//class Archer<K> : Unit<K>
//    where K : new()
//{
//    public Archer(K id) :
//        base(id)
//    { }
//}
//Archer<int> a = new Archer<int>(101);
//Unit<int> b = new Archer<int>(102);
//Unit<Role> c = new Archer<Role>(new Role());


// 2. Нетипизированный (необощенный) наследник
//class Archer: Unit<int>
//{
//    public Archer(int id) :
//        base(id)
//    { }
//}
//Archer a = new Archer(101);
//Unit<int> b = new Archer(102);


// 3. Типизация наследника отдельным конкретным типом
//class Archer<T> : Unit<int>
//{
//    public Archer(int id):
//        base(id)
//    { }
//}
//Archer<Role> a = new Archer<Role>(12);
//Unit<int> b = new Archer<Role>(34);


// 4. Комбинация разных вариантов

//class Archer<T, K> : Unit<T>
//    where T : new()
//{
//    public Archer(T id) :
//        base(id)
//    { }
//}

#endregion

#region Examples

//Dictionary<string, Planet> planets = new Dictionary<string, Planet>();
//planets.Add("Mercury", new Planet() { Radius = 2400, Weight = 0.2 });
//planets.Add("Venus", new Planet() { Radius = 4300, Weight = 0.7 });
//planets.Add("Earth", new Planet() { Radius = 6400, Weight = 1 });

//foreach(KeyValuePair<string, Planet> p in planets)
//{
//    Console.WriteLine($"{p.Key}: {p.Value}");
//}

//class Planet
//{
//    public int Radius { get; set; }
//    public double Weight { get; set; }
//    public override string ToString()
//    {
//        return $"r = {Radius}, w = {Weight}";
//    }
//}

#endregion
