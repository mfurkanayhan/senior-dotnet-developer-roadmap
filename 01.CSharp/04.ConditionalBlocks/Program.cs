Console.WriteLine("Hello, World!");

// Demonstrating 'if' blocks with logical operators
int a = 1;
int b = 2;

// This 'if' statement checks multiple conditions
if (a < 3 && (b == 1 || a != 1))
{
    Console.WriteLine("The condition is true.");
}
else
{
    Console.WriteLine("The condition is false.");
}

// Nested 'if' statements to demonstrate complex decision trees
if (a > 0)
{
    if (a == 1)
    {
        Console.WriteLine("a is equal to 1.");
    }
    else if (a == 2)
    {
        Console.WriteLine("a is equal to 2.");
    }
    else
    {
        Console.WriteLine("a is greater than 2.");
    }
}
else
{
    Console.WriteLine("a is not positive.");
}

// Using 'switch' statement for string comparison
string name = "Furkan";
switch (name)
{
    case "John":
        Console.WriteLine("Name is John.");
        break;
    case "Furkan":
        Console.WriteLine("Name is Furkan.");
        break;
    default:
        Console.WriteLine("Name is not recognized.");
        break;
}

// Demonstrating 'switch' with relational patterns
switch (a)
{
    case < 3:
        Console.WriteLine("a is less than 3.");
        break;
    default:
        Console.WriteLine("a is 3 or more.");
        break;
}

// 'switch' block for integer comparison
int vat = 20;
switch (vat)
{
    case 1:
        Console.WriteLine("VAT is 1%.");
        break;
    case 10:
        Console.WriteLine("VAT is 10%.");
        break;
    case 20:
        Console.WriteLine("VAT is 20%.");
        break;
    default:
        Console.WriteLine("VAT rate is not standard.");
        break;
}

Console.ReadLine(); // Wait for user input to keep the console open