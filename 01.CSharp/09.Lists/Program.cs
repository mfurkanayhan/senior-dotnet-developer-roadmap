using System;
using System.Collections.Generic;  // Required for using List

class Program
{
    static void Main()
    {
        // Creating a new list of strings
        List<string> names = new List<string>();

        // Adding elements to the list
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        // Displaying all names in the list
        Console.WriteLine("Names in the list:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Accessing elements by index
        Console.WriteLine($"\nThe first name in the list is: {names[0]}");

        // Modifying an element
        names[0] = "Alicia";
        Console.WriteLine("After modification:");
        Console.WriteLine($"The first name in the list is now: {names[0]}");

        // Removing an element
        names.Remove("Bob");  // This removes the first occurrence of "Bob"
        Console.WriteLine("\nAfter removing 'Bob':");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Adding multiple names
        names.AddRange(new string[] { "David", "Eve" });
        Console.WriteLine("\nAfter adding multiple names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Inserting an element at a specific index
        names.Insert(1, "Zach");
        Console.WriteLine("\nAfter inserting 'Zach' at index 1:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Removing an element by index
        names.RemoveAt(0);  // This removes the first element in the list
        Console.WriteLine("\nAfter removing the first element:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Checking if the list contains a specific element
        bool hasAlice = names.Contains("Alice");
        Console.WriteLine($"\nDoes the list contain 'Alice'? {hasAlice}");

        // Clearing all elements from the list
        names.Clear();
        Console.WriteLine($"After clearing, the list has {names.Count} elements.");
    }
}
