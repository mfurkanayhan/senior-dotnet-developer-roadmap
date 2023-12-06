namespace StudentAttandance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store student information
            List<Student> students = new();

            // Add students to the list
            students.Add(new Student()
            {
                No = 100,
                Name = "John Doe",
                IsInClass = false
            });

            var student1 = new Student()
            {
                No = 200,
                Name = "Jane Smith",
                IsInClass = false
            };
            students.Add(student1);

            students.Add(new Student()
            {
                No = 300,
                Name = "Alex Johnson",
                IsInClass = false
            });

            // Introduction messages
            Console.WriteLine("Welcome to the attendance application!");
            Thread.Sleep(1000);
            Console.WriteLine("I am AttendanceAI, your attendance control AI.");
            Thread.Sleep(1000);
            Console.WriteLine("After you answer for each student, I will show you the final status of the attendance.");
            Thread.Sleep(1000);
            Console.WriteLine("---------------------------");

            // Iterate through each student in the list
            for (int i = 0; i < students.Count; i++)
            {
                Student st = students[i];
            return_point:;
                // Ask if the student is present in the class
                Console.WriteLine($"{st.No}. {st.Name} is in class?");
                Console.WriteLine("(y) Yes, (n) No");
                string response = Console.ReadLine();

                // Set the IsInClass property based on the response
                if (response == "y")
                {
                    st.IsInClass = true;
                }
                else if (response == "n")
                {
                    st.IsInClass = false;
                }
                else
                {
                    // Handle invalid response
                    Console.WriteLine("You must answer with y or n. Please try again!");
                    goto return_point;
                }
                Thread.Sleep(300);
            }

            // Display the final status of the attendance
            Console.WriteLine("---------------------------------------");
            Thread.Sleep(1000);
            Console.WriteLine("Attendance successfully completed. Displaying the student list:");
            Thread.Sleep(1000);

            // Display each student's status
            students.ForEach(st =>
            {
                // Ternary operator / single if line | Instead of the above if/else statement, you can also prefer this usage.

                // Explanation: The ternary operator is a concise way to express conditional statements in a single line.
                // In the context of the code, it's suggesting the use of the ternary operator as an alternative to the traditional if/else statement for concise readability.

                // Example:
                // Original if/else statement
                // if (st.IsInClass == true)
                //     Console.WriteLine($"{st.Name} is in class");
                // else
                //     Console.WriteLine($"{st.Name} is not in class");

                // Ternary operator equivalent

                Console.WriteLine($"{st.No}. {st.Name} is {(st.IsInClass == true ? "in class" : "not in class")}");
            });
        }
    }
}
