// Declare and initialize an array of integers
int[] numbers = { 2, 4, 6, 8, 10 };

// Display the array elements
Console.WriteLine("Integer array elements:");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Change an array element
numbers[2] = 7;

// Display the modified array
Console.WriteLine("\nModified array elements:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Element at index {i}: {numbers[i]}");
}