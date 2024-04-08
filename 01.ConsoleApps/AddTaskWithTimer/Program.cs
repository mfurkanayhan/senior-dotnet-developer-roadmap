namespace AddTaskWithTimer;

// Class to hold task information.
class Task
{
    public string Name { get; set; } // The name of the task.
    public string Description { get; set; } // The description of the task.
    public int Duration { get; set; } // The repetition interval of the task (in milliseconds).
}

// Class to manage tasks and track them with timers.
class TaskManager
{
    private List<Timer> timers = new List<Timer>(); // List to hold created timers.

    public void AddTask(Task task)
    {
        // Create a timer for each task that prints task information at set intervals.
        Timer timer = new Timer((e) =>
        {
            Console.WriteLine($"Name: {task.Name}, Description: {task.Description}");
        }, null, task.Duration, task.Duration);

        timers.Add(timer); // Add the created timer to the list.
    }

    // Method to prompt the user for input and accept only non-empty entries.
    private static string ReadLineWithPrompt(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
        } while (string.IsNullOrEmpty(input)); // If the input is empty, ask again.

        return input;
    }

    public static void Main(string[] args)
    {
        TaskManager manager = new TaskManager();

        while (true) // Continue the loop until "exit" is entered.
        {
            var name = ReadLineWithPrompt("Task Name (or type 'exit' to quit): ");
            if (name.ToLower() == "exit")
                break; // Exit the loop if "exit" is entered.

            var description = ReadLineWithPrompt("Description: ");
            var durationString = ReadLineWithPrompt("Duration (ms): ");
            if (!int.TryParse(durationString, out int duration))
            {
                Console.WriteLine("Duration must be a number. Please try again.");
                continue; // If the duration is not a numeric value, re-enter the loop.
            }

            Task task = new Task
            {
                Name = name,
                Description = description,
                Duration = duration
            };

            manager.AddTask(task); // Add the created task to the manager.
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey(); // Wait for a key press to prevent the program from closing.
    }
}
