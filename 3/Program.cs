class Program
{
    static void Main()
    {
        int difference = 4 - 2;

        // National debt to the penny
        decimal debt = -18125876697430.99M;

        int n = '3' + '4';
        char c = (char)n;
        System.Console.WriteLine(c);    // writes out g.

        int distance = 'f' - 'c';
        System.Console.WriteLine(distance);     // 3


        decimal decimalNumber = 4.2M;
        double doubleNumber1 = 0.1F * 42F;
        double doubleNumber2 = 0.1D * 42D;
        float floatNumber = 0.1F * 42F;

        System.Diagnostics.Trace.Assert(decimalNumber != (decimal)doubleNumber1);
        // 1.Displays:4.2 != 4.20000006258488
        System.Console.WriteLine($"{decimalNumber} != {(decimal)doubleNumber}");

        System.Diagnostics.Trace.Assert((double)decimalNumber != doubleNumber1);
        // 2.Displays: 4.2 != 4.20000006258488
        System.Console.WriteLine($"{(double)decimalNumber} != {doubleNumber1}");

        System.Diagnostics.Trace.Assert((float)decimalNumber != floatNumber);
        // 3.Displays: (float)4.2M != 4.2F
        System.Console.WriteLine($"{(float)decimalNumber}M != {floatNumber}F");

        System.Diagnostics.Trace.Assert(doubleNumber1 != (double)floatNumber);
        // 4.Displays: 4.20000006258488 != 4.200000028610229
        System.Console.WriteLine($"{doubleNumber1} != {(double)floatNumber}");

        System.Diagnostics.Trace.Assert(doubleNumber1 != doubleNumber2);
        // 5.Displays: 4.20000006258488 != 4.2
        System.Console.WriteLine($"{doubleNumber1} != {doubleNumber2}");

        System.Diagnostics.Trace.Assert(floatNumber != doubleNumber2);
        // 6.Displays: 4.2F != 4.2D
        System.Console.WriteLine($"{floatNumber}F != {doubleNumber2}D");

        System.Diagnostics.Trace.Assert((double)4.2F != 4.2D);
        // 7.Display: 4.19999980926514 != 4.2
        System.Console.WriteLine($"{(double)4.2F} != {4.2D}");

        System.Diagnostics.Trace.Assert(4.2F != 4.2D);
        // 8.Display: 4.2F != 4.2D
        System.Console.WriteLine($"{4.2F}F != {4.2D}D");


        float n = 0f;
        // Displays: NaN
        System.Console.WriteLine(n / 0);

        // Displays: -Infinity
        System.Console.WriteLine(-1f / 0);
        // Displays: Infinity
        System.Console.WriteLine(3.402823E+38f * 2f);

        int x = 123;
        x = x + 2;

        int x = 123;
        x += 2;

        char current;
        int unicodeValue;

        current = 'z';

        do
        {
            // Retrieve the Unicode value of current.
            unicodeValue = current;
            System.Console.Write($"{current} = {unicodeValue}\t");

            // Proceed to the previus letter in the alplabet;
            current--;
        } while (current >= 's');


        int count = 123;
        int result;
        result = count++;
        System.Console.WriteLine($"result = {result} and count = {count}");

        count = 123;
        result = ++count;
        System.Console.WriteLine($"result = {result} and count = {count}");


        const int secondsPerDay = 60 * 60 * 24;
        const int secondsPerWeek = secondsPerDay * 7;

        string fileName = GetFileName();
        string fullName = fileName ?? "default.txt";
    }
}