class Program2
{
    static void Main(string[] args)
    {
        if (args?.Length == 0)
        {
            System.Console.WriteLine("ERROR: File missing. " + "Use:\n\tfind.exe file:<filename>");
        }
        else
        {
            if (args[0]?.ToLower().StartsWith("file:")??false)
            {
                string fileName = args[0]?.Remove(0, 5);
            }
        }

        string directoryPath = args?[0];
        string searchPattern = args?[1];


        int x;
        x = (-7 >> 2);  // 1111 1111 1111 1001 becomes
                        // 1111 1111 1111 1110
                        // write out "x is -2"
        System.Console.WriteLine($"x = {x}.");


        byte and, or, xor;
        and = 12 & 7;       // and = 4;
        or = 12 | 7;        // or = 15;
        xor = 12 ^ 7;       // xor = 11;
        System.Console.WriteLine($"and = {and}\nor = {or}\nxor = {xor}");

        and = 12;
        or = 12;
        xor = 12;
        and &= 7;       // and = 4
        or |= 7;        // or =15
        xor ^= 7;       // xor = 11
        System.Console.WriteLine($"and = {and}\nor = {or}\nxor = {xor}");





        bool valid = false;

        // Check the current player's input.
        if ((input == "1") ||
        (input == "2") ||
        (input == "3") ||
        (input == "4") ||
        (input == "5") ||
        (input == "6") ||
        (input == "7") ||
        (input == "8") ||
        (input == "9"))
        {
            // Save/move as the player directed.

            valid = true;
        }
        else if ((input == "") || (input == "quit"))
        {
            valid = true;
        }
        else
        {
            System.Console.WriteLine("\nERROR: Enter a value from 1-9. "
            + "Push ENTER to quit");
        }
    }


    static bool ValidateAndMove(int[] playerPositions, int currentPlayer, string input)
    {
        bool valid = false;

        // Check the current player's input.
        switch (input)
        {
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                // Save/move as the player directed

                valid = true;
                break;
            case "":
            case "quit":
                valid = true;
                break;
            default:
                // If none of the other case statements
                // is encountered then text is invalid.
                System.Console.WriteLine(
                    "\nERROR: Enter a value from 1-9. "
                    + "Push ENTER to quit."
                );
                break;
        }

        return valid;
    }
}