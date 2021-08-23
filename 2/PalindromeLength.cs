class PalindromeLength
{
    static void Main()
    {
        string palindrome;

        System.Console.Write("Enter a palindrome: ");
        palindrome = System.Console.ReadLine();

        System.Console.WriteLine(
            $"The palindrome \"{palindrome}\" is"
            + $" {palindrome.Length} characters."
        );
    }
}