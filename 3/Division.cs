class Division
{
    static void Main()
    {
        int numberator;
        int denominator;
        int quotient;
        int remainder;

        System.Console.Write("Enter the numberator: ");
        numberator = int.Parse(System.Console.ReadLine());

        System.Console.Write("Enter the denominator: ");
        denominator = int.Parse(System.Console.ReadLine());

        quotient = numberator / denominator;
        remainder = numberator % denominator;

        System.Console.WriteLine($"{numberator}/{denominator} = {quotient} with remainder {remainder}");
    }
}