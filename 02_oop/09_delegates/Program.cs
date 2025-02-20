
#region Intro
//ExecDel a;
//a = Process;
//a += User.Render;

//a();

//a.GetInvocationList();


//void Process()
//{
//    Console.WriteLine("Process");
//}

//class User
//{
//    public static void Render() => Console.WriteLine("User.Render()");
//}

//delegate void ExecDel();

// ExecDel --> MulticastDelegate --> Delegate --> object



//void SendEmail(string content) => Console.WriteLine($"Email: {content}");
//void SendTelegram(string content) => Console.WriteLine($"Telegram: {content}");
//void SendSms(string content) => Console.WriteLine($"Sms: {content}");

//NotifyHandler h1 = SendEmail;
//NotifyHandler h2 = SendTelegram;
//NotifyHandler h3 = SendSms;

//// h1("Vasia");
//// h3 += SendEmail;
////h3("Vasia");

//NotifyHandler h4 = h1 + h2 + h3;
////h4("Vasia");
////h4 -= SendTelegram;
////h4 -= SendEmail;
////h4("Vasia");

//if (h1 is not null)
//    h1("Petya");

//h1?.Invoke("Petya");        // :-)


//delegate void NotifyHandler(string content);
#endregion

#region Generic delegates

//string Process(int a, int b) => $"a + b = {a + b}";

//Operation<string, int> op = Process;
//Console.WriteLine(op?.Invoke(3, 4));


//delegate T Operation<T, P>(P a, P b);

#endregion

#region Practice "Observer"

Account acc = new Account(1000);

acc.RegisterSuccessHandler(TelegramNotifier.Notify);

acc.RegisterErrorHandler(TelegramNotifier.Notify);
acc.RegisterErrorHandler(SmsNotifier.Notify);
acc.RegisterErrorHandler(EmailNotifier.Notify);

acc.Add(500);
acc.Withdraw(2000);


class TelegramNotifier
{
    public static void Notify(string message) => Console.WriteLine($"Telegram: {message}");
}
class EmailNotifier
{
    public static void Notify(string message) => Console.WriteLine($"Email: {message}");
}
class SmsNotifier
{
    public static void Notify(string message) => Console.WriteLine($"Sms: {message}");
}
class Account
{
    public delegate void NotifyHandler(string message);

    private NotifyHandler successHandler;
    private NotifyHandler errorHandler;

    private int sum;

    public void RegisterSuccessHandler(NotifyHandler handler) => successHandler += handler;
    public void RegisterErrorHandler(NotifyHandler handler) => errorHandler += handler;

    public Account(int sum) => this.sum = sum;

    public void Add(int sum)
    {
        this.sum += sum;

        successHandler?.Invoke($"Added: {sum}");
    }

    public void Withdraw(int sum)
    {
        if (sum > this.sum)
            errorHandler?.Invoke("Invalid sum");
        else
        {
            this.sum -= sum;
            successHandler?.Invoke($"Withdrawen: {sum}");
        }
    }
}





#endregion


