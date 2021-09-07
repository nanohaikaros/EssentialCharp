// class HeyYou
// {
//     static void Main()
//     {
//         string firstName;
//         string lastName;

//         System.Console.WriteLine("Hey you!");

//         System.Console.Write("Enter your first name: ");

//         firstName = System.Console.ReadLine();
//         System.Console.Write("Enter your last name: ");
//         lastName = System.Console.ReadLine();
//         System.Console.WriteLine(&"Your full name is {firstName} {lastName}.");
//     }
// }

using static System.Console;

class HeyYou
{
    static void Main()
    {
        string firstName;
        string lastName;

        WriteLine("Hey you!");

        Write("Enter your first name: ");

        firstName = ReadLine();
        Write("Enter your last name: ");
        lastName = ReadLine();
        WriteLine(&"Your full name is {firstName} {lastName}.");
    }
}