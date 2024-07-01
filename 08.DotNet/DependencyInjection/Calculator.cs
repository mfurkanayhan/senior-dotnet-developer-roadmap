namespace DependencyInjection;

public class Calculator
{
    public int Total { get; set; }
    public Calculator()
    {
        
    }

    public int Add(int firstNumber, int secondNumber)
    {
        Total += firstNumber + secondNumber;
        return Total;
    }

    public int Subtract(int firstNumber, int secondNumber) 
    {
        return firstNumber - secondNumber;
    }
}

// Access Modifiers in C#

// public => Accessible from any code. | Used when you want members to be universally accessible.

// private => Accessible only within the same class. | Used to encapsulate members and prevent outside access.

// internal => Accessible only within the same assembly. | Used to limit access to the same project.

// protected => Accessible within its class and by derived class instances. | Used to allow access to derived classes.