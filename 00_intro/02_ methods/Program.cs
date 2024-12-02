
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

#region params
//int Sum(params int[] values)
//{
//    int res = 0;
//    foreach(int val in values)
//        res += val;

//    return res;
//}

//Console.WriteLine(Sum(4, 5, 6, 7, 8));
//Console.WriteLine(Sum());
//int[] arr = [4, 5, 6, 7];
//Console.WriteLine(Sum(arr));


//int Sum(int init, params int[] values)
//{
//    int res = init;
//    foreach (int val in values)
//        res += val;

//    return res;
//}

//Console.WriteLine(Sum(4, 5, 6, 7, 8));
//Console.WriteLine(Sum(0));
//int[] arr = [4, 5, 6, 7];
//Console.WriteLine(Sum(0, arr));

#endregion

#region Local functions

//void Compare(int[] a, int[] b)
//{
//    int s1 = Sum(a);
//    int s2 = Sum(b);

//    if (s1 > s2)
//        Console.WriteLine("a > b");
//    else
//        Console.WriteLine("a < b");

//    int Sum(int[] arr)
//    {
//        int res = 0;
//        foreach (int val in arr)
//            res += val;
//        return res;
//    }

//    static void Test()
//    {
//        // Console.WriteLine(s1);           // ERROR
//    }
// }

#endregion

#region switch
//int val = 45;
//switch(val)
//{
//    case 1:
//        //
//        //
//        break;
//    case 3:
//    case 4:
//        //
//        //
//        break;
//    default:
//        goto case 3;
//        //
//        //
//        break;
//}


//int Calc(int a, int b, int operation)
//{
//    switch(operation)
//    {
//        case 0:
//            return a + b;
//        case 1:
//            return a * b;
//        case 2:
//            return a / b;
//        case 3:
//            return a - b;
//    }

//    return 0;
//}


//int Calc(int a, int b, int operation)
//{
//    int res = operation switch
//    {
//        0 => a + b,
//        1 => a * b,
//        2 => a / b,
//        3 => a - b,
//        _ => throw new NotImplementedException()
//    };

//    return res;
//}



//int Calc(int a, int b, int operation) => operation switch
//{
//    0 => a + b,
//    1 => a * b,
//    2 => a / b,
//    3 => a - b,
//    _ => throw new NotImplementedException()
//};

#endregion

#region enum

// Status a = 2;        // ERROR
//Status b = Status.Fatal;
//Console.WriteLine(b);
//Console.WriteLine((int)b);

//enum Status: byte
//{
//    Running = 2,
//    Pending = 4,
//    Finished = 8,
//    Error = 2,
//    Fatal = Error,
//}


//int Sum(int a, int b, Operation op) => op switch
//{ 
//    Operation.Add  => a + b,
//    Operation.Dec  => a - b,
//    Operation.Mul  => a * b,
//    Operation.Div  => a / b,
//    _ => throw new NotSupportedException(),
//};

//enum Operation
//{
//    Add,
//    Dec,
//    Mul,
//    Div,
//}

#endregion

