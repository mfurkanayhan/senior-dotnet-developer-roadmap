namespace StudentAttendance;

internal class Program
{
    static void Main(string[] args)
    {
        // string[] students = new string[4]; //array
        List<Student> students = new()
        {
            new Student()
            {
                No = 1,
                Name = "John Doe",
                Class = "1A",
                DateOfBirth = Convert.ToDateTime("23.05.1995"),
            },
            new Student()
            {
                No = 2,
                Name = "Jane Smith",
                Class = "1A",
                DateOfBirth = Convert.ToDateTime("10.06.1995")
            }
        };

        var student = new Student()
        {
            No = 3,
            Name = "Alex Johnson",
            Class = "1A",
            DateOfBirth = Convert.ToDateTime("10.06.1995")
        };

        students.Add(student);


        Console.WriteLine("Hi, this is my students!");

        foreach (var s in students)
        {
            /*Console.WriteLine($@"
                Number: {s.No}
                Name: {s.Name}
                Class: {s.Class}
                Date Of Birth: {s.DateOfBirth}
                --------------------");
            */
            Console.WriteLine($"{s.No}. {s.Name}");
        }

        while (true)
        {
            // Check if all students are in class.
            foreach (var s in students)
            {
                if (!s.IsInClass)
                {
                    goto start; // Jump to the block labeled 'start'
                }
            }

            Console.WriteLine("All students are in class!");
            break;

        start:; // Label
            Console.WriteLine("Tell me who is in class?");
            string noString = Console.ReadLine();
            int no = 0;
            // Check if the input is numeric.
            bool result = int.TryParse(noString, out no);
            if (!result)
            {
                Console.WriteLine("Please write a number!");
                continue;
            }

            // Check if there is a student with the entered number.
            result = students.Any(x => x.No == no);
            if (!result)
            {
                Console.WriteLine("The number you entered doesn't belong to our class. Please try again!");
                continue;
            }

            // Check if the student with the entered number is already marked as present in class.
            Student st = students.FirstOrDefault(p => p.No == no);
            if (st.IsInClass)
            {
                Console.WriteLine("This student already in class!");
                continue;
            }

            // Mark the student as present in class.
            st.IsInClass = true;
            Console.WriteLine($"{st.Name} marked as present in class.");
        }
    }
}

// Access Modifier
internal class Student
{
    public int No { get; set; }
    public string Name { get; set; } // property, TitleCase
    public string Class { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsInClass { get; set; } = false;
}
