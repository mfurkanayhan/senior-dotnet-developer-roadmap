namespace MyFirstConsoleApp
{
    internal class Program
    {
        // { } Scope - Code Block - is one of the programming terms and represents the area where a variable, function, or object is accessible. There are two common types:

        // 1. Global Scope: It represents the scope that can be accessed by the entire program.

        // 2. Local Scope: It represents the scope usually defined within a code block or function, and cannot be accessed by code outside of those areas.

        // Scope manages the availability and security of variables. It prevents variable name conflicts and helps keep the code organized. Scope rules can vary depending on the programming language and the flow of the program.

        public static int globalVariable = 10; // Global Scope

        static void Main(string[] args)
        {
            Console.WriteLine(globalVariable);

            int localVariable = 5; // Local Scope
            Console.WriteLine(localVariable);

            // Comment Line - Also, "//" double slashes are used to define everything written as a comment. They are commonly used to add information, tips, etc. between code lines.

            // To print variables, we use Console.WriteLine.
            Console.WriteLine("Hello, World!"); // This code prints "Hello, World!" to the screen.
            Console.WriteLine("Furkan Ayhan"); // This code prints "Furkan Ayhan" to the screen.
            Console.WriteLine("Furkan" + " " + "Ayhan"); // The + operator has a special function for concatenating textual values, allowing us to combine multiple letters or words.
            // This way of writing gives the same result as the previous one.
            // Note: Only the + operator has a function in textual values; -, *, / operators have no function.

            // Variables

            // Variable Syntax Structure
            // type variable_name = value;
            // string firstMessage = "Hello World!";
            // According to the rules, the first letter of a variable is always written in lowercase. If the variable name consists of multiple words, the other words are written in uppercase.

            // Syntax Error - It is a coding error that occurs when there is a letter or declaration error in the code.

            // Variable Types

            // string

            // The string data type is used to represent text or character strings.
            // Text is used to store and process text-based data. For example, text can represent messages displayed to users, names, addresses, file paths, and much more.
            // The string data type can store variable-length text, meaning the text length can change dynamically.
            // The string data type is written inside double quotes, and you can use the + operator to concatenate text values.

            // Let's define two text variables, first name and last name:
            string firstName = "Furkan";
            string lastName = "Ayhan";
            Console.WriteLine("Full Name: " + firstName + " " + lastName);

            // You can concatenate text with other strings:
            string greeting = "Hello, " + firstName + "!";
            Console.WriteLine(greeting);

            // You can use the Length property to find out the length of text:
            int nameLength = (firstName + " " + lastName).Length;
            Console.WriteLine("Name Length: " + nameLength);

            // You can convert text to uppercase or lowercase:
            string upperCaseFullName = (firstName + " " + lastName).ToUpper();
            string lowerCaseFullName = (firstName + " " + lastName).ToLower();
            Console.WriteLine("Uppercase Name: " + upperCaseFullName);
            Console.WriteLine("Lowercase Name: " + lowerCaseFullName);

            // int

            // Int is a data type used to represent integers.
            // Integers are used to represent positive or negative whole numbers and do not have a decimal part.
            // The int data type is often used for mathematical calculations, storing quantities, and processing numerical data.
            // The int data type is typically stored in a specific size in computer memory (e.g., 32 bits or 64 bits), allowing it to represent integers within a certain range.

            // Let's define a few integer variables:
            int age = 28; // Represents a person's age.
            Console.WriteLine("Age: " + age);

            int quantity = 10; // Represents the quantity of a product.
            Console.WriteLine("Product Quantity: " + quantity);

            // You can perform mathematical operations:
            int total = age + quantity; // Adds age and quantity.
            Console.WriteLine("Total: " + total);

            // decimal - double - float

            // The decimal data type is used to represent decimal numbers with high precision. It is commonly used in financial applications or precise calculations involving fractional numbers.
            // Decimal variables can perform calculations with high precision, supporting millions of decimal places.

            decimal salary = 47500.20m; // The "m" letter indicates that this number is definitely a decimal.
            Console.WriteLine("My salary: " + salary);

            // Double and float variables are used to represent decimal numbers, but they have lower precision compared to decimal.
            // These variables are commonly used in scientific calculations, engineering applications, or general-purpose numerical computations.
            // Double has more precision than float.

            double pi = 3.141592653589793238;
            float weight = 67.5f; // The "f" letter indicates that this number is a float.
            Console.WriteLine("Value of Pi: " + pi);
            Console.WriteLine("My weight is " + weight + " kilograms.");

            // bool (boolean)

            // The bool data type represents only two values: "true" or "false."
            // The bool data type is commonly used when asking questions. "Is it true? Is the operation successful? Should the operation continue?" It returns either true or false (similar to 0 or 1).
            // The bool data type is widely used in controlling the flow of programs (e.g., using control structures like "if" and "while").

            // Let's define two bool variables:
            bool isActive = true; // Used to represent whether a user's account is active.
            Console.WriteLine(isActive);

            bool isUserAdmin = false; // Used to indicate whether a user is an administrator.

            // For example:

            if (isActive)
            {
                Console.WriteLine("User account is active.");

                if (isUserAdmin)
                {
                    Console.WriteLine("User has administrator privileges.");
                }
                else
                {
                    Console.WriteLine("User is not an administrator.");
                }
            }
            else
            {
                Console.WriteLine("User account is not active.");
            }

            // We'll explain Conditional Statements in the next project. For now, understanding the logic is sufficient.

            // datetime

            // The DateTime data type is used to represent date and time information.
            // It allows you to work with date and time, such as getting the current date and time, creating a specific date and time, calculating differences between two date and time values, or displaying a date in a specific format.

            // You can get the current date and time using DateTime.Now:
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + currentDateTime);

            // You can create a specific date and time using DateTime constructors:
            DateTime customDateTime = new DateTime(2023, 11, 3, 14, 30, 0);
            Console.WriteLine("Specific Date and Time: " + customDateTime);

            // You can perform operations on date and time using DateTime objects:
            DateTime futureDate = customDateTime.AddMonths(1);
            Console.WriteLine("Date 1 month from now: " + futureDate);

            DateTime pastDate = customDateTime.AddYears(-5);
            Console.WriteLine("Date 5 years ago: " + pastDate);

            // You can calculate the difference between two DateTime objects using TimeSpan:
            TimeSpan timeDifference = futureDate - customDateTime;
            Console.WriteLine("Difference between two dates: " + timeDifference.Days + " days");

            // You can format a DateTime object to a specific date and time format using the ToString method:
            string formattedDate = customDateTime.ToString("dd/MM/yyyy HH:mm:ss");
            Console.WriteLine("Formatted Date: " + formattedDate);

            string readLine = Console.ReadLine();
            Console.WriteLine("Value entered from the keyboard: " + readLine);

            // object - It is the entirety of the classes, lists, and similar structures we create. Object is a broad topic, so I will end it here for now.
        }
    }
}
