using System;

class ConvertToPhoneNumber
{
    static int Main(string[] args)
    {
        char button;

        if(args.Length == 0)
        {
            Console.WriteLine("ConvertToPhoneNumber.exe <phrase>");
            Console.WriteLine("'_' indicates no standard phone button");
            return 1;
        }
        foreach (string word in args)
        {
            foreach (char character in word)
            {
                if(TryGetPhoneButton(character, out button))
                {
                    Console.Write(button);
                }
                else
                {
                    Console.Write('_');
                }
            }
        }

        Console.WriteLine();
        return 0;
    }

    static bool TryGetPhoneButton(char character, out char button)
    {
        bool success = true;
        switch(char.ToLower(character))
        {
            case '1':
                button = '1';
                break;
            case '2':
            case 'a':
            case 'b':
            case 'c':
                button = '2';
                break;
            
            case '-':
                button = '-';
                break;

            default:
                // Set the button to indicate an ainvalid value 
                button = '_';
                success = false;
                break;
        }
        return success;
    }
}