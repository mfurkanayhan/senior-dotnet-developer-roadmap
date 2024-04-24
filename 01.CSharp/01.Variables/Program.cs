Console.WriteLine("Hello World!");

// Define variables with default values
string name; // null by default
int age; // 0 by default
bool isActive; // false by default

float n1 = 100;
int n2 = 200;
var n3 = n1 + n2; // 'var' infers the type based on the expression on the right side
Console.WriteLine(n3.GetType()); // Outputs the type of 'n3'

string nameLastName = "M.Furkan Ayhan";
name = "blablabla";
char karakter = 'F'; // 'char' holds a single character and uses single quotes
string description = "Variables are containers used to store data. In C#, a variable is defined by specifying the data type first, followed by the variable name. An initial value may be assigned or it can be assigned later.";

Console.WriteLine(nameLastName + "\n");
Console.WriteLine(description);
Console.ReadLine(); // Waits for an input to prevent the console from closing immediately
