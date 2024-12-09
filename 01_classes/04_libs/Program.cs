using _04_libs;
using FileCombine;
using MathLib.Kernel;
using Newtonsoft.Json;

FileEngine fe = new();
fe.Show();

Calculator calc = new Calculator();
Console.WriteLine(calc.Execute(Operation.Add, 3, 4));

User user = new User(101, "Vasia@mail.com", 23);

string json = JsonConvert.SerializeObject(user);
Console.WriteLine(json);

User result = JsonConvert.DeserializeObject<User>(json);
result.Render();




