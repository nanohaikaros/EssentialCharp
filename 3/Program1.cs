class Program1
{
    static void Main()
    {
        int playerCount;
        System.Console.Write("Enter the number of players (1 or 2):");
        playerCount = int.Parse(System.Console.ReadLine());

        if (playerCount != 1 && playerCount != 2)
        {
            string message = "You entered an invalid number of players.";
        }
        else
        {

        }
        // Error: message is not in scope.
        System.Console.WriteLine(message);
    }
}