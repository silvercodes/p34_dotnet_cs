namespace MathLib.Kernel;

public class Calculator
{
    public int Execute(Operation op, int a, int b) => op switch 
    { 
        Operation.Add => a + b,
        Operation.Sub => a - b,
        Operation.Mul => a * b,
        Operation.Div => a / b,

        _ => throw new NotImplementedException()
    };
}
