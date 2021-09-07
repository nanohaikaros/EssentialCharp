using System;

class ExceptionHandling2
{
    static void Main()
    {
        string firstName;
        string ageText;
        int age;
        int result = 0;

        Console.WriteLine("Hey you!");

        Console.Write("Enter your first name: ");
        firstName = System.Console.ReadLine();

        Console.Write("Enter your age: ");
        ageText = Console.ReadLine();

        try
        {
            age = int.Parse(ageText);
            Console.WriteLine($"Hi {firstName}! You are {age * 12} months old.");
        }
        finally
        {
            Console.WriteLine($"Goodbye {firstName}");
        }
        return result;

    }
}