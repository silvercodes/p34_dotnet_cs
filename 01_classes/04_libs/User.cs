namespace _04_libs;

internal class User
{
    public int id;
    public string email;
    public int age;
    public User(int id, string email, int age)
    {
        this.id = id;
        this.email = email;
        this.age = age;
    }

    public void Render() => Console.WriteLine($"{id} {email} {age}");
}
