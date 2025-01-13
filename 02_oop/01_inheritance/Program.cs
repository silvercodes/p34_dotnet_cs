
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

// upcasting (восходящее преобразование / упаковка объекта)
Warrior warrior = new Warrior(100, 60);

Unit unit = warrior;                    // upcasting

object o = warrior;                     // upcasting


// downcasting (нисходящее преобразование / распаковка объекта)




class Unit
{
    public int Hp { get; set; }
    public Unit(int hp)
    {
        Hp = hp;
    }
    public void Render() => Console.WriteLine($"hp: {Hp}");
}

class Warrior: Unit
{
    public int Force { get; set; }
    public Warrior(int hp, int force):
        base(hp)
    {
        Force = force;
    }
}

class Archer: Unit
{
    public int ArrCount { get; set; }
    public Archer(int hp, int arrCount) :
        base(hp)
    {
        ArrCount = arrCount;
    }
}

#endregion



