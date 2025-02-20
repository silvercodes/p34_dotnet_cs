
Report report = new Report();

IHandler db = new DbHandler();
IHandler domain = new DomainHandler();
IHandler deploy = new DeployHandler();

deploy
    .SetNext(db)
    .SetNext(domain);

try
{
    deploy.Processing();
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}


class Report
{
    public Dictionary<string, string> MyProperty { get; set; }
}

interface IHandler
{
    public IHandler SetNext(IHandler next);
    public void Processing();
    public void Rollback();
}
abstract class Handler: IHandler
{
    protected IHandler? Next { get; set; } = null;
    public IHandler SetNext(IHandler next)
    {
        Next = next;

        return next;
    }
    public abstract void Processing();
    public abstract void Rollback();
}

class DbHandler : Handler
{
    public override void Processing()
    {
        try
        {
            Console.WriteLine("DB created...");

            Next?.Processing();
        }
        catch (Exception)
        {
            Rollback();

            throw;
        }
    }

    public override void Rollback()
    {
        Console.WriteLine("DB deleted...");
    }
}
class DomainHandler : Handler
{
    public override void Processing()
    {
        try
        {
            Console.WriteLine("Domain created...");

            Next?.Processing();
        }
        catch (Exception)
        {
            Rollback();

            throw;
        }
    }

    public override void Rollback()
    {
        Console.WriteLine("Domain deleted...");
    }
}
class DeployHandler : Handler
{
    public override void Processing()
    {
        try
        {
            Console.WriteLine("Deployment success...");

            Next?.Processing();
        }
        catch (Exception)
        {
            Rollback();

            throw;
        }
    }

    public override void Rollback()
    {
        Console.WriteLine("Deployment rolled back...");
    }
}