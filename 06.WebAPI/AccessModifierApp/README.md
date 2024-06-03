# AccessModifierApp
## Overview
The AccessModifierApp is a C# demonstration designed to elucidate the use of different access modifiers. This project provides practical examples to help developers understand how these modifiers control the visibility of class members across various contexts.

## Project Structure
This project is structured into several C# files, each illustrating different access modifiers:

- **Test1.cs**
- **Test2.cs**
- **Test3.cs**
- **Program.cs**

## Key Concepts
### Access Modifiers
C# access modifiers determine the visibility of class members. Here’s how they are applied in this project:

- **Public**: No restrictions—visible everywhere.
- **Internal**: Only visible within the same assembly.
- **Protected**: Only visible within the class and derived classes.
- **Private**: Only visible within the class.

### Code Examples

#### Test1.cs

```csharp
public class Test1
{
    public string PublicProperty { get; init; }
    internal string InternalProperty { get; } = "1";
    private string PrivateProperty { get; set; }
    protected string ProtectedProperty { get; set; } = string.Empty;
}

public class TestInherit : Test1
{
    public string NewPublicProtectedProperty { get; set; }

    public TestInherit()
    {
        ProtectedProperty = "John";
        NewPublicProtectedProperty = ProtectedProperty;
    }
}
```

#### Test2.cs

```csharp
class Test2
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
}
```

#### Test3.cs

```csharp
internal class Test3
{
    public string PublicProperty { get; set; }
    internal string InternalProperty { get; set; }
    private string PrivateProperty { get; set; }
    protected string ProtectedProperty { get; set; }
}
```

#### Program.cs
```csharp
Console.WriteLine("Hello, World!");

Test1 test1 = new() { PublicProperty = "John" };
Console.WriteLine($"Public Property from Test1: {test1.PublicProperty}");

Test2 test2 = Test2.Create("John");
Console.WriteLine($"Internal Property from Test2 (via factory method): {test2.InternalProperty}");

TestInherit testInherit = new();
Console.WriteLine($"Protected Property accessed via public property in TestInherit: {testInherit.NewPublicProtectedProperty}");

Console.WriteLine("Private property cannot be accessed outside of its class.");
```

### Usage

Compile and run the **\`Program.cs`** file to see the effects of different access modifiers in action. The console output will demonstrate accessible properties and explain access restrictions.

### Conclusion

This project illustrates the fundamental principles of C# access modifiers, providing a clear understanding necessary for designing secure and well-structured software applications.