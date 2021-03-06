using System;

class ExceptionHandling1
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

        if (int.TryParse(ageText, out age))
        {
            Console.WriteLine(
                $"Hi {firstName}!"
                + $"You are {age * 12} months old."
            );
        }
        else
        {
            Console.WriteLine($"The age entered, {ageText}, is not valid.");
        }

        try
        {
            age = int.Parse(ageText);
            Console.WriteLine($"Hi {firstName}! You are {age * 12} months old.");
        }
        catch (FormatException)
        {
            Console.WriteLine($"The age entered, {ageText}, is not valid.");
            result = 1;
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Unexpected error: {exception.Message}");
            result = 1;
        }
        catch
        {
            Console.WriteLine("Unexpected error!");
            result = 1;
        }
        finally
        {
            Console.WriteLine($"Goodbye {firstName}");
        }
        return result;

    }
}