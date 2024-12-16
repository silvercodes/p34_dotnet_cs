
#region Intro
//Console.WriteLine();

//User a = new User()
//{
//    Id = 101,
//    Email = "vasia@mail.com",
//};

//// Console.WriteLine(a.Id);     // ERROR
//a.Id = 102;

//Console.WriteLine(a.Test);
//a.Test = "Petya";

//Console.WriteLine(a.Info);
//// a.Info = "str";          // ERROR

//class User
//{
//    private int id;
//    private string email;

//    public int Id
//    {
//        set => id = value;
//    }
//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//        set
//        {
//            email = value.ToLower();
//        }
//    }

//    public string Test
//    {
//        get
//        {
//            return "Vasia";
//        }
//        set
//        {
//            Console.WriteLine($"set -> {value}");
//        }
//    }
//    //public string Info                      // свойство "только для чтения"
//    //{
//    //    get => $"id: {id} email: {Email}";
//    //}
//    // >>> EQUALS <<<
//    public string Info => $"id: {id} email: {Email}";   // свойство "только для чтения"
//}

#endregion

#region modificators
//Unit a = new Unit("WaRrIor");
//Console.WriteLine(a.Title);
//class Unit
//{
//    private string title = string.Empty;
//    public Unit(string title) => Title = title;

//    // :-)
//    public string Title
//    {
//        get => title;
//        private set => title = value.ToLower();
//    }

//    // ;-(
//    //public string Title
//    //{
//    //    private set => title = value.ToLower();
//    //}

//    // :-(
//    //public string Title
//    //{
//    //    private get => title;
//    //    private set => title = value.ToLower();
//    //}

//    // ;-(
//    //private string Title
//    //{
//    //    get => title;
//    //    public set => title = value.ToLower();
//    //}
//}
#endregion

#region Auto-properties

//Unit a = new Unit();
//Console.WriteLine(a.Age);

//class Unit
//{
//    public int Id { get; set; }
//    // >>> EQUALS <<<
//    //private int K_back_id;
//    //public int Id
//    //{
//    //    get => K_back_id;
//    //    set => K_back_id = value;
//    //}

//    public string Email { get; set; } = "no_email";
//    public string City { get; private set; }
//    public int Age { get; }

//}

#endregion

#region init

//User a = new()
//{
//    Email = "Vasia@mail.com"            // case 2
//};
//// a.Email = "dima@mail.com";           // ERROR

//class User
//{
//    private string nickname;
//    public string Email { get; init; } = "no_email";        // case 3
//    public string Nickname 
//    {
//        get => nickname;
//        init
//        {
//            nickname = value;
//            Email = "no_email";             // case 4 :-(
//        }
//    }
//    public User() { }
//    public User(string email)
//    {
//        Email = email;                      // case 1
//    }
//    public void Render()
//    {
//        // Email = "kolia@mail.com";        // ERROR
//    }
//}

#endregion

#region required

User a = new("vasia@mail.com")
{
    level = 1,
    Id = 101,
};
class User
{
    public required int level;
    public required int Id { get; set; }
    public string Email { get; set; }
    public User(string email)
    {
        Email = email;
    }
}

#endregion
