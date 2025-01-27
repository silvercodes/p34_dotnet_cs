
//          C++                     C#
// чистая виртуальная ф-ция     абстрактный метод (является виртуальным)
// абстрактный класс            абстрактный класс
// интерфейсный класс           интерфейс

// Абстрактными членами класса в C# могу быть:
// 1. Методы
// 2. Свойства
// 3. События
// 4. Индексаторы

#region Intro
//abstract class Unit
//{
//    public int Id { get; set; }                  // Автосвойство (get, set, private field)
//    public virtual int Hp { get; set; }          // Автосвойство (virtual get, virtual set, private field)
//    public abstract string? Name { get; set; }   // НЕ автосвойство (abstract get, abstract set)
//    public Unit()
//    { }
//    public abstract void Defence();
//    public virtual void Move() => Console.WriteLine("Unit.Move()");
//    public void Attack() => Console.WriteLine("Unit.Attack()");
//}

//class Archer : Unit
//{
//    public new int Id
//    {
//        get => base.Id;
//        set => base.Id = value;
//    }
//    public override int Hp
//    {
//        get => base.Hp;
//        set => base.Hp = value;
//    }
//    public override string? Name { get; set; } = null;
//    public Archer()
//    { }
//    public override void Defence() => Console.WriteLine("Archer.Move()");
//    public override void Move() => Console.WriteLine("Archer.Move()");
//    public new void Attack() => Console.WriteLine("Archer.Attack()");
//}

#endregion

#region Object virtual methods

object a = new Product()
{
    Id = 101,
    Title = "phone",
};

Console.WriteLine(a);


class Product
{
    public int Id { get; set; }
    public string Title { get; set; }

    public override string ToString()
    {
        return $"id: {Id}, title: {Title}";
    }
    public override int GetHashCode()
    {
        return Title.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        if (obj is Product p)
            return Id == p.Id;

        return false;
    }
}

#endregion




