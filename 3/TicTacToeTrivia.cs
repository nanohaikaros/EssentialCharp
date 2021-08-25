class TicTacToeTrivia
{
    static void Main()
    {
        int input;      // Declare a variable to store the input

        System.Console.Write(
            "What is the maximum number " +
            "of turns in tic-tac-toe?" +
            "(Ente 0 to exit.): "
        );

        // int.Parse() converts the ReadLine()
        // return to an int data type.
        input = int.Parse(System.Console.ReadLine());

        // if (input <= 0)     // line 16
        //                     // Input is less than or equal to 0.
        //     System.Console.WriteLine("Exiting...");
        // else
        //     if (input < 9)  // line 20
        //                  // Input is less than or equal to 0.
        //         System.Console.WriteLine($"Tic-tac-toe has more than {input}" + " maximum turns.");
        //     else
        //         if (input > 9)  // line 26
        //                         // Input is greater than 9.
        //             System.Console.WriteLine($"Tic-tac-toe has fewer than {input}" + " maximum turns.");
        //         else            // line 33
        //                         // Input equals 9.
        //             System.Console.WriteLine("Correct, tic-tac-toe " + "has a maximum of 9 turns.");

        if (input < 0)
            System.Console.WriteLine("Exiting...");
        else if (input < 9)
            System.Console.WriteLine($"Tic-tac-toe has moew than {input}" + " maximum tuens.");
        else if (input > 9)
            System.Console.WriteLine($"Tic-tac-toe has less than {input}" + " maximum turns.");
        else
            System.Console.WriteLine("Correct, tic-tac-toe has a maximum " + "of 9 thrns.");
    }
}