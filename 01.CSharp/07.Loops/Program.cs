List<string> names = new List<string>
{
    "Furkan",   // Index 0
    "John",   // Index 1
    "Michelle",   // Index 2
    "Jane",  // Index 3
    "Gloria",  // Index 4
    "Arthur"    // Index 5
};

// Demonstrating a 'for' loop
Console.WriteLine("\nUsing a 'for' loop:");
for (int i = 0; i < names.Count; i++)
{
    if (i == 4)
    {
        Console.WriteLine("Breaking the loop at index 4");
        break; // Exits the loop when i equals 4
    }

    if (i == 2)
    {
        Console.WriteLine("Skipping index 2");
        continue; // Skips the current iteration when i equals 2
    }

    Console.WriteLine($"Name at index {i}: {names[i]}");
}

// Demonstrating a 'foreach' loop
Console.WriteLine("\nUsing a 'foreach' loop:");
foreach (var name in names)
{
    Console.WriteLine($"Name: {name}");
}

// Demonstrating a 'while' loop
Console.WriteLine("\nUsing a 'while' loop:");
int count = 0;
while (count < names.Count)
{
    Console.WriteLine($"Name at count {count}: {names[count]}");
    count++;  // Increment to avoid infinite loop
}

// Demonstrating a 'do-while' loop
Console.WriteLine("\nUsing a 'do-while' loop:");
int index = 0;
do
{
    Console.WriteLine($"Name at index {index}: {names[index]}");
    index++;
} while (index < names.Count);

// Note on 'do-while': Executes the loop body at least once before checking the condition.