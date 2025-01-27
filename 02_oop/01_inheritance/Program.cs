
#region Intro
// Ограничения
// 1. Только одиночное наследование (множество интерфейсов :-))
// 2. Модификатор доступа наследника - такой же или более строгий
// 3. Если класс sealed - наследование запрещено
// 4. Запрещено наследоваться от статического класса



//User a = new User(23);
//Admin b = new Admin(34);

//class User
//{
//    public int Age { get; set; }
//    public  User(int age = 18)
//    {
//        Age = age;
//    }
//    public void Show()
//    {
//        Console.WriteLine($"User: {Age}");
//    }
//}

//class Admin: User
//{
//    public string Email { get; set; }  
//    public Admin(int age) :
//        this(age, "vasia@mail.com")
//    {}
//    public Admin(int age, string email):
//        base(age)
//    {
//        Email = email;
//    }

//    public void Render()
//    {
//        base.Show();
//        Console.WriteLine($"Age: {Age}");
//    }
//}

#endregion

#region Type casting (преобразование типа ссылки)

//// upcasting (восходящее преобразование / упаковка объекта)
//Warrior warrior = new Warrior(100, 60);

//Unit unit = warrior;                    // upcasting

//object o = warrior;                     // upcasting



// downcasting (нисходящее преобразование / распаковка объекта)

//Archer archer1 = new Archer(100, 10);

//Unit unit = archer1;                    // <-- upcasting

//Archer archer2 = (Archer)unit;          // <-- downcasting
//Warrior warrior2 = (Warrior)unit;       // ERROR runtime

//void Method(Unit unit)
//{

//}



// === as / is ===

//Unit unit = new Archer(100, 10);

//Archer a = (Archer)unit;            // if error => EXCEPTION
//Archer? b = unit as Archer;         // if error => null

//if (b is not null)
//    b.Render();

//b?.Render();


//if (unit is Archer)
//{
//    Archer archer = (Archer)unit;
//    archer.ArrCount = 15;
//}
// >>>EQUALS<<<
//if (unit is Archer archer)
//    archer.ArrCount = 15;


//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp)
//    {
//        Hp = hp;
//    }
//    public void Render() => Console.WriteLine($"hp: {Hp}");
//}

//class Warrior : Unit
//{
//    public int Force { get; set; }
//    public Warrior(int hp, int force) :
//        base(hp)
//    {
//        Force = force;
//    }
//}

//class Archer : Unit
//{
//    public int ArrCount { get; set; }
//    public Archer(int hp, int arrCount) :
//        base(hp)
//    {
//        ArrCount = arrCount;
//    }
//}

#endregion

#region virtual / override

//Student student = new Student(101);
//student.Render();

//User user = new Student(102);
//user.Render();

//Student? s = user as Student;
//if (s is not null)
//    s.Render();


//User a = new Student(103);
//a.Age = 23;
//a.Render();


//User a = new SuperStudent(104);
//a.Render();


//class User
//{
//    public int Id { get; set; }
//    public virtual int Age { get; set; }
//    public User(int id)
//    {
//        Id = id;
//    }
//    public virtual void Render() => Console.WriteLine($"Render from User: {Id}");
//}

//class Student: User
//{
//    // public override int Age { get; set; }       // <<< fu fu fu
//    public override int Age 
//    { 
//        get
//        {
//            Console.WriteLine("Age get() from Student");
//            return base.Age;
//        }
//        set
//        {
//            Console.WriteLine("Age set() from Student");
//            base.Age = value;
//        }
//    }
//    public Student(int id) :
//        base(id)
//    { }

//    public override void Render()
//    {
//        Console.WriteLine($"Render from Student: {Id}");
//    }
//}

//class SuperStudent: Student
//{
//    public SuperStudent(int id) : 
//        base(id) 
//    { }
//    //public override void Render()
//    //{
//    //    // base.Render();
//    //    Console.WriteLine($"Render from SuperStudent: {Id}");
//    //}
//}


#endregion

#region Hiding

//Admin admin = new Admin(101, "vasia@mail.com");
//admin.Render();

//User user = new Admin(102, "petya@mail.com");
//user.Render();


//Console.WriteLine(User.maxAge);
//Console.WriteLine(Admin.maxAge);


//Admin admin = new Admin(101, "vasia@mail.com");
//User user = new Admin(102, "petya@mail.com");

//admin.Email = "dima@mail.com";
//user.Email = "kolya@mail.com";



//class User
//{
//    public int Id { get; set; }
//    public readonly static int maxAge = 18;
//    public const double PI = 3.14;
//    public string Email { get; set; } = "no_email";
//    public User(int id, string email)
//    {
//        Id = id;
//        Email = email;
//    }
//    public void Render()
//    {
//        Console.WriteLine($"User: {Email}");
//    }
//}

//class Admin: User
//{
//    public new readonly static int maxAge = 21;
//    public new const double PI = 3.1415;
//    public Admin(int id, string email):
//        base(id, email)
//    { }

//    // public new string Email { get; set; }       // Fu FU FU

//    public new string Email
//    {
//        get => $"admin...  {base.Email}";
//        set
//        {
//            Console.WriteLine($"Admin setEmail with {value}");
//            base.Email = value;
//        }
//    }


//    public new void Render()
//    {
//        Console.WriteLine(User.maxAge);
//        Console.WriteLine(maxAge);
//        Console.WriteLine($"Admin: {Email}");
//    }
//}



#endregion
