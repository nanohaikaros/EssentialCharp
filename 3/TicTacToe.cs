class TicTacToe
{
    static void Main()
    {
        string input;

        // Prompt the user to select a 1- or 2-player game.
        System.Console.Write(
            "1 - Play against the computer\n" +
            "2 - play against another player.\n" +
            "Choose:"
        );

        input = System.Console.ReadLine();

        if (input=='1')
        {
            // The user selected to play the computer
            System.Console.WriteLine("Play against computer selected.");
        }
        else
            // Default to 2 players (even if user didn't enter 2).
            System.Console.WriteLine("Play against another player.");

        int currentPlayer = 1;

        for (int turn = 1; turn <= 10; turn++)
        {
            currentPlayer = (currentPlayer == 2) ? 1 : 2;
        }


        bool valid;
        do
        {
            valid = false;

            // Request a move from the current player.
            System.Console.Write($"\nPlayer {currentPlayer}: Enter move:");
            input = System.Console.ReadLine();

            // Check the current player's input.
        } while (!valid);



        char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        System.Console.Write("The acailable moves are as follows: ");

        // Write out hte initial available moves
        foreach (char cell in cells)
        {
            if (cell != 'O' && cell != 'X')
            {
                System.Console.Write($"{cell}");
            }
        }


        int winner = 0;
        // Stores locations each player has moved.
        int[] playerPositions = { 0, 0 };

        playerPositions[0] = 449;
        playerPositions[1] = 28;

        int[] winningMasks = { 7, 56, 448, 73, 146, 292, 84, 273 };

        foreach (int mask in winningMasks)
        {
            if ((maskk &playerPositions[0]) == mask)
            {
                winner = 1;
                break;
            }
            else if ((mask & playerPositions[1]) == mask)
            {
                winner = 2;
                break;
            }
        }

        System.Console.WriteLine($"Player{winner} was the winner");
    }
}