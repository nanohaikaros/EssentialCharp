class HeyYou
{
    static void Main()
    {
        // string firstName;
        // string lastName;

        // System.Console.WriteLine("Hey you!");

        // System.Console.Write("Enter your first name: ");
        // firstName = System.Console.ReadLine();

        // System.Console.Write("Enter your last name: ");
        // lastName = System.Console.ReadLine();


        // int readValue;
        // char character;
        // readValue = System.Console.Read();
        // character = (char)readValue;

        // System.Console.Write(character);

        // string firstName;
        // string lastName;

        // System.Console.WriteLine("Hey you!");

        // System.Console.Write("Enter your first name: ");
        // firstName = System.Console.ReadLine();

        // System.Console.Write("Enter your last name: ");
        // lastName = System.Console.ReadLine();

        // System.Console.WriteLine($"Your full name is {firstName} {lastName}.");

        string firstName;
        string lastName;

        System.Console.WriteLine("Hey you!");

        System.Console.Write("Enter your first name: ");
        firstName = System.Console.ReadLine();

        System.Console.Write("Enter your last name: ");
        lastName = System.Console.ReadLine();

        System.Console.WriteLine("Your full name is {0} {1}.", firstName, lastName);
        System.Console.WriteLine("Your full name is {1} {0}", firstName, lastName);
    }
}