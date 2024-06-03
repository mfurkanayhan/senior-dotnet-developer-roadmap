namespace AccessModifierApp.Models;
class Test2 // Factory Pattern
{
    private Test2(string internalProperty)
    {
        InternalProperty = internalProperty;
    }
    public string PublicProperty { get; private set; }
    internal string InternalProperty { get; init; }
    private string PrivateProperty { get; set; }
    protected string ProtectedProperty { get; set; }


    public static Test2 Create(string internalProperty)
    {
        return new Test2(internalProperty);
    }

    public void Update(string property)
    {
        PublicProperty = property;
    }
}