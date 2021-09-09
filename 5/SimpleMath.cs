using System;

public static class SimpleMath
{
    public static int Max(params int[] numbers)
    {
        if(numbers.Length == 0)
        {
            throw new ArgumentException("numbers cannot be empty", "numbers");
        }

        int result;
        result = numbers[0];
        foreach (int number in numbers)
        {
            if(number>result)
            {
                result = number;
            }
        }
        return result;
    }

    public static int Min(params int[] numbers)
    {
        if(numbers.Length == 0)
        {
            throw new ArgumentException("numbers cannot be empty", "numbers");
        }

        int result;
        result = numbers[0];
        foreach (int number in numbers)
        {
            if(number < result)
            {
                result = number;
            }
        }
        return result;
    }
}