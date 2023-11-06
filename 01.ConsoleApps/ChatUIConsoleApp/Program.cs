using System;

namespace ChatUIConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I am Chat UI.");
            Console.WriteLine("I want to know you better.");
            Console.WriteLine("Please tell me your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + name);

            Console.WriteLine("Where are you from?");
            string from = Console.ReadLine();
            Console.WriteLine("Oh, that's great! I am from Turkey.");

            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();

            // Conditional Statements

            /* In the C# programming language, conditional blocks are structural elements used to control the flow of a program. Here's a brief summary to explain conditional blocks:

                `if` Statements: It checks whether a condition is true or false and, if the condition is true, executes a specific code block.

                `else if` Statements: It is used to check multiple conditions. If the first `if` condition is not true, consecutive `else if` statements are evaluated, and the code block of the first true condition is executed.

                `else` Statements: It defines the code block to be executed when none of the `if` or `else` `if` conditions are true.

                These conditional blocks allow programs to exhibit different behaviors based on specific conditions. For example, you can make a program do something if a certain condition is true, making your programs more flexible and versatile.
             */

            // Let's add a conditional block to validate the user's age now.

            if (int.TryParse(ageInput, out int age)) // This statement attempts to convert a text input into an integer and, if the conversion is successful, assigns the result to an integer variable named "age."
            {
                // This block will run if the user provides an age.
                Console.WriteLine("Great! You are " + age + " years old.");
            }
            else
            {
                // This block will run if the user does not provide an age or enters an invalid input.
                Console.WriteLine("I'm sorry, but that doesn't look like a valid age.");
                age = 0; // Age will be assumed as 0 when there is an invalid input.
            }

            Console.WriteLine("Am I correct? Please answer with 'Yes' or 'No'.");
            string answer = Console.ReadLine();


            // Switch Statements: Used to compare multiple options and execute different code blocks. It is especially useful when different actions need to be taken for specific values of a variable.

            // Let's provide a different response based on the user's answer.
            switch (answer.ToLower())
            {
                case "yes":
                    Console.WriteLine("That's great. I am really happy!");
                    break;
                case "no":
                    Console.WriteLine("Oh, I am sorry for misunderstanding.");
                    break;
                default:
                    Console.WriteLine("I don't understand your response!");
                    break;
            }
            Console.WriteLine("-------------------------------------------------");
            /* Bonus!
               Ternary Expressions: Used for short and simple conditional expressions. It evaluates a condition and creates an expression that returns different values depending on that condition.
            */
            // Example:
            int number = 7;
            string result = (number > 5) ? "Big" : "Small";
            Console.WriteLine(result);
        }
    }
}
