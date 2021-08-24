class Casting
{
    static void Main()
    {
        long longNumber = 50918309109;
        int intNumber = (int)longNumber;

        // int.MaxValue equals 2147483647
        int n = int.MaxValue;
        n = n + 1;
        System.Console.WriteLine(n);    // -2147483648

        checked
        {
            // int.MaxValue equals 2147483647
            n = int.MaxValue;
            n = n + 1;
            System.Console.WriteLine(n);
        }

        unchecked
        {
            // int.MaxValue equals 2147483647
            n = int.MaxValue;
            n = n + 1;
            System.Console.WriteLine(n);
        }

        intNumber = 31416;
        long longNumber = intNumber;

        intNumber = 31416;
        longNumber = (long)intNumber;

        // 使用int.Parse() 将一个string转换为数值数据类型
        string text = "9.11E-31";
        float kgElectronMass = float.Parse(text);

        // 使用System.Convert将一种类型转换成另一种类型
        string middleCText = "261.626";
        double middleC = System.Convert.ToDouble(middleCText);
        bool boolean = System.Convert.ToBoolean(middleC);


        boolean = true;
        text = boolean.ToString();
        System.Console.WriteLine(text);



        double number;
        string input;

        System.Console.Write("Enter a number: ");
        input = System.Console.ReadLine();
        if(double.TryParse(input, out number))
        {

        }
        else 
        {
            System.Console.WriteLine("The text entered was not a valid number.");
        }
    }
}