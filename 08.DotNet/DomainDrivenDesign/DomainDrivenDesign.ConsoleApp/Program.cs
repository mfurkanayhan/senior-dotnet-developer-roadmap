/*
MemoryCache memoryCache = new();
memoryCache.CreateCache();

abstract class Cache
{
    public virtual void CreateCache()
    {

    }
}

class MemoryCache : Cache
{
    public override void CreateCache()
    {
        Console.WriteLine("Memory Cache yap");
    }
}

class RedisCache : Cache
{
    public override void CreateCache()
    {
        Console.WriteLine("Redis Cache yap");
    }
}

User user1 = new()
{
    Id = 1,
    FirstName = "Furkan",
    LastName = "Ayhan",
    Email = "mfurkanayhan@gmail.com",
};


User user2 = new()
{
    Id = 1,
    FirstName = "Furkan",
    LastName = "Ayhan",
    Email = "mfurkanayhan@gmail.com",
};

var result = user1.Equals(user2);

Console.WriteLine($"User1 User2'ye eşit mi?: {result}");

Console.ReadLine();
*/

/*
public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;

        if (obj is not User user) return false;

        if (obj.GetType() != typeof(User)) return false;

        return user.Id == Id;
    }

    public static bool operator ==(User left, User right)
    {
        if (left is null || right is null) return false;

        if (left.GetType() != right.GetType()) return false;

        return left.Id == right.Id;
    }

    public static bool operator != (User left, User right)
    {
        if (left is null || right is null) return true;

        if (left.GetType() != right.GetType()) return true;

        return left.Id == right.Id;
    }
}

*/

namespace Program
{
    public class Program
    {
        public static void Main()
        {
        }
    }
}
/*

using System;
public class Test2
{
    public int Value { get; set; }

    // Constructor
    public Test2(int value)
    {
        Value = value;
    }

    // Overloaded + operator
    public static Test2 operator +(Test2 a, Test2 b)
    {
        // Calculate the sum of values
        int sum = a.Value + b.Value;
        // Print the sum to the console
        Console.WriteLine(sum);
        // Return a new Test2 object with the sum of values
        return new Test2(sum);
    }
}

public class Program
{
    public static void Main()
    {
        Test2 t1 = new Test2(5);
        Test2 t2 = new Test2(3);
        Test2 result = t1 + t2; // This will print "8" to the console
    }
}
*/