namespace ModificatorsLib;



public class Class1
{
    private int privateField;
    public int publicField;
    protected int protectedField;
    private protected int privateProtectedField;
    internal int internalField;
    protected internal int protectedInternalField;
}

class Class2 : Class1
{
    public void Test()
    {
        privateProtectedField = 56;

        internalField = 678;

        protectedInternalField = 543;
    }
}