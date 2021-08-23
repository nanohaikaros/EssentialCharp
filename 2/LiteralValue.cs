class LiteralValue
{
    static void Main()
    {
        System.Console.WriteLine(42);
        System.Console.WriteLine(1.618034);
        System.Console.WriteLine(1.618033988749895);// 1.61803398874989
        // 指定decimal字面量
        System.Console.WriteLine(1.618033988749895M);   // 1.618033988749895 
        // 指数记数法
        System.Console.WriteLine(6.023E23F);

        // 十六进制记数法 value 42
        System.Console.WriteLine(0x002A);

        // displays "0x2A“
        System.Console.WriteLine($"0x{42:X}");

        const double number = 1.618033988749895;
        double result;
        string text;

        text = $"{number}";
        result = double.Parse(text);
        System.Console.WriteLine($"{result == number}: result == number");

        text = string.Format("{0:R", number);
        result = double.Parse(text);
        System.Console.WriteLine($"{result == number}: resutlt == number");

        string option;
        bool comparison = string.Compare(option, "/Help", true);
    }
}