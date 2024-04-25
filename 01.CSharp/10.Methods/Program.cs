class Program
{
    static void Main()
    {
        int result = Add(5, 3);
        Console.WriteLine("5 + 3 = " + result);

        int subtractionResult = Subtract(10, 6);
        Console.WriteLine("10 - 6 = " + subtractionResult);

        DisplayGreeting("Furkan");
    }

    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }

    static void DisplayGreeting(string name)
    {
        Console.WriteLine("Hello, " + name);
    }
}