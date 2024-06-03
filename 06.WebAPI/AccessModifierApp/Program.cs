using AccessModifierApp.Models;

Console.WriteLine("Hello, World!");

// Public Access Modifier
Test1 test1 = new() { PublicProperty = "John" };
Console.WriteLine($"Public Property from Test1: {test1.PublicProperty}");

// Internal Access Modifier
// Accessible because it's internal and we're within the same assembly
Test2 test2 = Test2.Create("John");
Console.WriteLine($"Internal Property from Test2 (via factory method): {test2.InternalProperty}");

// Protected Access Modifier (via inheritance)
TestInherit testInherit = new();
Console.WriteLine($"Protected Property accessed via public property in TestInherit: {testInherit.NewPublicProtectedProperty}");

// Private Access Modifier
// Not accessible here because private properties are only accessible within their own class
Test3 test3 = new();
Console.WriteLine("Private property cannot be accessed outside of its class.");

// Uncommenting the following line will cause a compilation error because PrivateProperty is private
// Console.WriteLine($"Private Property from Test3: {test3.PrivateProperty}");

// Since Test3's private and protected properties cannot be accessed directly,
// they are not displayed. Demonstrating usage here with comments instead.