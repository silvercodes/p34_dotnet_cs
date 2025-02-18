
// try / catch / finally / throw

//try
//{
//    int a = 5;
//    int b = 0;

//    Console.WriteLine(a / b);

//    Console.WriteLine("extra"); 
//}
//catch(Exception ex)
//{
//    Console.WriteLine("handling");
//}
//finally
//{
//    Console.WriteLine("finallly");
//}

//Console.WriteLine("End main");




//int a = 5;
//int b = 0;

//Console.WriteLine(a / b);




// DivideByZeroException
// IndexOutOfRangeException
// NullReferenceException
// ArgumentException
// InvalidCastException



//int a = 4;
//int b = 2;
//int c = 0;

//try
//{
//	c = a / b;
//    Console.WriteLine($"c = {c}");

//    int[] arr = new int[3];
//    Console.WriteLine(arr[10]);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Source);
//    Console.WriteLine(ex.TargetSite);
//    Console.WriteLine(ex.InnerException);
//    Console.WriteLine(ex.HelpLink);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Source);
//    Console.WriteLine(ex.TargetSite);
//    Console.WriteLine(ex.InnerException);
//    Console.WriteLine(ex.HelpLink);
//}




//void A()
//{
//    throw new Exception("ERROR");
//    Console.WriteLine("A");
//}
//void B()
//{
//    A();
//    Console.WriteLine("B");
//}
//void C()
//{
//    B();
//    Console.WriteLine("C");
//}
//void D()
//{
//    C();
//    Console.WriteLine("D");
//}
//void E()
//{
//    D();
//    Console.WriteLine("E");
//}

//try
//{
//    E();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Source);
//    Console.WriteLine(ex.TargetSite);
//    Console.WriteLine(ex.InnerException);
//    Console.WriteLine(ex.HelpLink);
//}




throw new GameException("Error message")
{
    Level = 3,
    Code = 1200,
};

class GameException: Exception
{
    public int Level { get; set; }
    public int Code { get; set; }
    public GameException(string message) :
        base(message)
    { }
}



