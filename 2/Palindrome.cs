class Palindrome
{
    static void Main()
    {
        string reverse, palindrome;
        char[] temp;

        System.Console.Write("Enter a palidrome: ");
        palindrome = System.Console.ReadLine();

        // Remove spaces and convert to lowercase
        reverse = palindrome.Replace(" ", " ");
        reverse = reverse.ToLower();

        // Convert to an array
        temp = reverse.ToCharArray();

        // Reverse the array
        System.Array.Reverse(temp);

        // Comvert the array back to a string and 
        // check if reverse string is the same.
        if(reverse == new string(temp))
        {
            System.Console.WriteLine($"\"{palindrome}\" is a palindrome.");
        }
        else
        {
            System.Console.WriteLine($"\"{palindrome}\" is NOT a palidrme.");
        }
    }
}