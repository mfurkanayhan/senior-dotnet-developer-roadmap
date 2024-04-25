// Operators Example in C#
int a = 0, b = 1;
bool isEqual = (a == b);  // Check if a is equal to b

// Arithmetic operations
int result = ((5 * 2) + 5) - 0;  // Calculates and stores the result

int number = 1;
number += 5;  // Adds 5 to number

// Increment and Decrement
int counter = 1;
counter++;  // Increases counter by 1
counter--;  // Decreases counter by 1

// String manipulation
string name = "M.Furkan";
string fullName = name + " Ayhan";  // Concatenates two strings
string details = $"{fullName}, a 28-year-old Computer Engineer";  // Uses string interpolation

// Using verbatim string
string url = @"http:\";  // Correctly formats the backslash

// Using modulus operator
int remainder = counter % 2;  // Calculates remainder of counter divided by 2

Console.WriteLine(fullName);  // Displays the full name
// To display the output of other variables, simply use the Console.WriteLine() method 
// and write the name of the variable whose value you want to see.
// For example, to display the value of 'details', you can write:
Console.WriteLine(details);
Console.ReadLine();  // Waits for a user input
