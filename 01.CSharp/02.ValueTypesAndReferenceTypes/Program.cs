namespace ValueTypesAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value type example: int
            int number1 = 10;
            int number2 = number1;
            number2 = 20;
            Console.WriteLine(number1);  // Output: 10
            Console.WriteLine(number2);  // Output: 20
            // number1 and number2 are independent; changing number2 does not affect number1.

            // Reference type example: User class
            User user1 = new User();
            User user2 = user1;
            user2.Name = "Ayhan";
            Console.WriteLine(user1.Name);  // Output: Ayhan
            // user1 and user2 reference the same User object; changes made to user2 also affect user1.
        }
    }
}

class User
{
    public string Name = "Furkan";
}
