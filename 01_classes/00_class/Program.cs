
//User a = new User();
//a.id = 1;
//a.email = "vasia@mail.com";
//a.Render();

//class User
//{
//    public int id;
//    public string email;
//    // public User() { }

//    public void Render() => Console.WriteLine($"id: {id}, email: {email}");
//}

using _00_class;

//User a = new User(150, "dima@mail.com");
//a.Render();

//User b = new User(101);
//User c = new User("petya@mail.xom");

// User a = new User(101);


// ---- initializer  ----
User a = new User(120)
{
    id = 150,
    email = "petya@mail.com",
    username = "babushka"
};
a.Render();





