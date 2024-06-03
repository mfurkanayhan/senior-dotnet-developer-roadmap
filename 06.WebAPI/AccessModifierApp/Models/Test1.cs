namespace AccessModifierApp.Models;
public class Test1
{
    public string PublicProperty { get; init; }
    internal string InternalProperty { get; } = "1"; //set part is readonly
    private string PrivateProperty { get; set; }
    protected string ProtectedProperty { get; set; } = string.Empty;
}

public class TestInherit : Test1
{
    public string NewPublicProtectedProperty { get; set; }
    public TestInherit()
    {
        Test4 test4 = Test4.Method("Value");
        test4.ChangeName("New Value");
        ProtectedProperty = "John";
        NewPublicProtectedProperty = ProtectedProperty;
    }
}

public class Test4
{
    private Test4(string name)
    {
        if (name.Length < 3)
        {
            throw new Exception("Error!");
        }

        Name = name;
    }
    public string Name { get; private set; }
    public static Test4 Method(string value)
    {
        return new(value);
    }

    public void ChangeName(string name)
    {
        Test test = new("Furkan", "Ayhan", "Zonguldak", "Software Developer");
        TestRecord record = new("Furkan", "Ayhan", "Zonguldak", "Software Developer");
        Name = name;
    }
}

public sealed record TestRecord(
    string Name,
    string LastName,
    string Address,
    string Profession);

public sealed record TestRecord2
{
    public TestRecord2(string name, string lastName, string address, string profession)
    {
        Name = name;
        LastName = lastName;
        Address = address;
        Profession = profession;
    }

    public string Name { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Profession { get; set; }
}
public sealed class Test
{
    public Test(string name, string lastName, string address, string profession)
    {
        Name = name;
        LastName = lastName;
        Address = address;
        Profession = profession;
    }

    public string Name { get; init; }
    public string LastName { get; init; }
    public string Address { get; init; }
    public string Profession { get; init; }
}
