
#region Intro
//class Program
//{
//    static void Main()
//    {

//        // локальная функция
//        void render()
//        {

//        }

//        render();
//    }

//    // метод
//    void Render()
//    {

//    }
//}


//void Render()
//{
//    Console.WriteLine("Render");
//}

//Render();
#endregion

#region Parameters Intro
//int Sum(int a, int b)
//{
//    return a + b;
//}

//Console.WriteLine(Sum(3, 4));

//void Render(string message)
//{
//    Console.WriteLine(message);
//}
// >>> EQUALS <<<
//  void Render(string message) => Console.WriteLine(message);



//void Sum(int a, int b) => Console.WriteLine(a + b);
//Sum(3, 4);

//void Render(string message, bool colored = false)
//{
//    if (colored)
//        Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(message);

//    Console.ResetColor();
//}

//Render("vasia", true);
//Render("petya");


// ==== именованые параметры ====

//void Render(int id, string email = "no_email", int age = 18)
//{
//    Console.WriteLine($"id: {id}, email: {email} age: {age}");
//}

//Render(101, "no_email", 23);
//Render(age: 34, id: 201);
//Render(202, age: 45);

// =====  return  =====

//string GetClearEmail(string email)
//{
//    return email.ToLower();
//}

//Console.WriteLine(GetClearEmail("VasiA@MAIL.com"));

// >>> EQUALS <<<

//string GetClearEmail(string email) => email.ToLower();

//Console.WriteLine(GetClearEmail("VasiA@MAIL.com"));

#endregion

#region ref / in / out / ref readonly
// -- передача "по-значению" --

// значимый тип - копируется значение
// ссылочный тип - копируется ссылка

// -- передача "по-ссылке" (ref) --
//void Modify1(User u)
//{
//    u.id = 202;     // :-)

//    u = new User(); // только локально!
//    u.id = 505;
//}

//void Modify2(ref User u)
//{
//    u.id = 202;     // :-)

//    u = new User(); // пересоздание объекта под внешнюю ссылку
//    u.id = 505;
//}

//void Render(User u) => Console.WriteLine($"id: {u.id}");

//User user = new User();

////Modify1(user);
////Render(user);

////Modify2(ref user);
////Render(user);

//class User
//{
//    public int id = 120;
//}




//// -- передача "по-ссылке" (in)  Входной параметр --

//void Modify(in User u)
//{
//    u.id = 202;
//    // u = new User(); //  ERROR
//}

//void Render(User u) => Console.WriteLine($"id: {u.id}");

//User user = new User();
//Modify(in user);
//Render(user);

//class User
//{
//    public int id = 120;
//}




// -- передача "по-ссылке" (out) Выходной параметр --
//void Modify(out User u)
//{
//    //
//    u = new User();
//    u.id = 303;
//    //
//}

//void Render(User u) => Console.WriteLine($"id: {u.id}");

////User user;
////Modify(out user);
////Render(user);
//// >>> EQUALS <<<
//Modify(out User user);
//Render(user);

//class User
//{
//    public int id = 120;
//}


// -- передача "по-ссылке" (ref readonly) Выходной параметр --
//
//

#endregion



