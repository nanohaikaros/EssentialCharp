using System;

public class Program3
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[args.Length];
        for (int count = 0; count < args.Length; count++)
        {
            numbers[count] = args[count].Length;
        }

        Console.WriteLine($@"Longest argument length = {SimpleMath.Max(numbers)}");
        Console.WriteLine($@"Shortest argument length = {SimpleMath.Min(numbers)}");
    }
}