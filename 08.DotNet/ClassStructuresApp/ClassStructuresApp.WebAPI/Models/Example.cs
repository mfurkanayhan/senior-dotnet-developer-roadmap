namespace ClassStructuresApp.WebAPI.Models;

public class Example // Public Protected Internal Private
{
    public Example() 
    {
        
    }

    public Example (int id)
    {
        Id = id;
    }

    // I can create properties
    public int Id { get; set; }
    // I can create variables
    public int age;
    // I can create methods
    public void Method()
    {

    }

    public int publicVariables;
    private int privateVariables;
    protected int protectedVariables;
    internal int internalVariables;
}

public class Consumer
{
    Example example = new();
    public Consumer()
    {

    }
}