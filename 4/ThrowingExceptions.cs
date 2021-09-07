using System;

public class ThrowingExceptions
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Begin executing");
            Console.WriteLine("Throw exception");
            throw new Exception("Arbitrary execption");
            Console.WriteLine("End executing");
        }
        catch(FormatException exception)
        {
            Console.WriteLine("A FormateException was throw");
        }
        catch(Exception exception)
        {
            Console.WriteLine($"Unexpected error: {exception.Message}");
            Console.WriteLine($@"Rethrowing unexpected error: {exception.Message}");
            throw;
        }
        catch
        {
            Console.WriteLine("Unexpected error!");
        }
        Console.WriteLine("Shutting down...");
    }
}