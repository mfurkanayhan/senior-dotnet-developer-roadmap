namespace _11.Classes;

internal class Program
{
    static void Main(string[] args)
    {
        // Instantiate the class
        Person person1 = new Person("Furkan", 28);

        // Use class methods and properties
        person1.Introduce();
    }
}

public class Person
{
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name { get { return name; } set { name = value; } }
    public int Age { get { return age; } set { age = value; } }

    // Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Method
    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");

        // Console.ReadLine(); // Uncomment the line below if you are running this program outside an IDE like Visual Studio to prevent the console window from closing immediately after the program finishes.
    }
}