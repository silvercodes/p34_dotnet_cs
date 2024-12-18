
#region Reference types
//string a = null;

//void F(string str)
//{
//    if (str == null)
//        return;
//    Console.WriteLine(str.ToLower());
//}

//F(null);


//# nullable disable
//string a = null;
//# nullable restore

//string? b = null;

//void F(string str)
//{
//    Console.WriteLine(str.ToLower());
//}

//F(a);
//F(b);



// ==== null-forgiving  operator ====
//string? email = null;

//string Normalize(string content)
//{
//    return content.ToLower();
//}

////if (email != null)
////    Normalize(email);

//Normalize(email!);

//class User
//{
//    public string Email { get; set; } = null!;
//}
#endregion

#region Value types

//int? a = null;
//if (a == null)

// Nullable<int> age = null;
// >>> EQUALS <<<
// int? age2 = null;


//int? age = null;
//Console.WriteLine(age.GetValueOrDefault(100));
//if (age != null)
//{ }
//if (age.HasValue)
//{ }


//int? a = 34;
//int b = (int)a;
//int c = a.Value;
//int? d = a;


//int? a = 56;
//// int b = a + 4;      // ERROR
//int? b = a + 4;
//int c = (int)a + 4;
//int d = a.Value + 4;

//int a = 12;
//int? b = a;

//long? a = 34;
//int? b = (int?)a;

#endregion

#region Null guard

//void Show(string? message)
//{
//    if (message == null)
//        return;

//    if (message is null)
//        return;

//    if (message is not null)
//        Console.WriteLine(message.ToUpper());

//    if (message is string)
//        Console.WriteLine(message.ToUpper());

//    Console.WriteLine(message.ToUpper());
//}

#endregion

#region null-union operator

//string? input = null;
//string email = input ?? "no_email";
//// >>> EQUALS <<<
//string email2 = input is not null ? input : "no_email";


//int? input = 23;
//int age = input ?? 18;

// string? email = null;
// email ??= "no_email";       // email = email ?? "no_email"

#endregion

#region Условный null

//void Execute(User? user)
//{
//    if (user != null && user.Role is not null)
//        user.Role.Render();
//    // >>> EQUALS <<<
//    user?.Role?.Render();
//}

//class Role
//{
//    public string? Title { get; set; } = null;
//    public void Render() => Console.WriteLine($"title: {Title}");
//}

//class User
//{
//    public Role? Role { get; set; } = null;
//}

#endregion
