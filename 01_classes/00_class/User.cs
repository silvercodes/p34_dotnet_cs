namespace _00_class;

#region Base using
//internal class User
//{
//    public int id;
//    public string email;

//    public User(int id, string email)
//    {
//        this.id = id;
//        this.email = email;
//    }
//    public User(int id)
//    {
//        this.id = id;
//        email = "no_email";
//    }
//    public User(string email)
//    {
//        id = 0;
//        this.email = email;
//    }

//    public void Render() => Console.WriteLine($"id: {id}, email: {email}");
//}
#endregion

#region Delegation
internal class User
{
    public int id;
    public string email;
    public required string username;

    public User(int id, string email)
    {
        this.id = id;
        this.email = email;
    }
    public User(int id) :
        this(id, "no_email")
    { }
    public User(string email) :
        this(0, email)
    { }

    public void Render() => Console.WriteLine($"id: {id}, email: {email}");
}
#endregion

#region Primary ctor
//class User(int id, string email)
//{
//                                        //private int id;
//                                        //private string email;

//                                        //public User(int id, string email)
//                                        //{
//                                        //    this.id = id;
//                                        //    this.email = email;
//                                        //}
//    public User(int id) :
//        this(id, "no_email")
//    { }
//    public User(string email) :
//        this(0, email)
//    { }

//    public void Render() => Console.WriteLine($"id: {id}, email: {email}");
//}
#endregion




