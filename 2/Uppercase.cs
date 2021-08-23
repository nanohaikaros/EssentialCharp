class Uppercase
{
    static void Main()
    {
        string text;
        string uppercase;

        System.Console.WriteLine("Enter text: ");
        text = System.Console.ReadLine();

        // UNEXPECTED: Does not convert text to uppercase
        text.ToUpper();

        System.Console.WriteLine(text);

        // Return a new string in uppercase
        uppercase = text.ToUpper();

        System.Console.WriteLine(uppercase);

        System.Console.Write("Enter text: ");
        var text = System.Console.ReadLine();

        // Return a new string in uppercase
        var uppercase = text.ToUpper();

        System.Console.WriteLine(uppercase);
    }
}