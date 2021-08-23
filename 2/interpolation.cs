class interpolation
{
    static void Main()
    {
        string text;
        string firstName;
        string lastName;

        System.Console.WriteLine("Hey you!");

        System.Console.Write("Enter your first name: ");

        firstName = System.Console.ReadLine();
        System.Console.Write("Enter your last name: ");

        lastName = System.Console.ReadLine();
        System.Console.WriteLine($"Your full name is {firstName} {lastName}.");

        System.Console.WriteLine($@"Your full name is: 
        {firstName} {lastName}.");  // 输出两行

        System.Console.WriteLine($@"Your full name is: {
            firstName} {lastName}.");

        object[] args = new object[] { firstName, lastName };
        System.Console.WriteLine(string.Format("Your full name is {0} {1}.", args));    // $"" == string.Format()

        text = string.Concat(firstName, lastName);  // 合并字符串
        System.Console.WriteLine(text);

        int result = string.Compare(firstName, lastName);   // 对比
        System.Console.WriteLine(result);

        bool isPhd = lastName.EndsWith("Ph.D.");
        bool isDr = lastName.StartsWith("Dr.");

        string serverity = "warning";
        System.Console.WriteLine(serverity.ToUpper());

        firstName = firstName.Trim();

        string filename;

        filename = filename.Replace("?", "");
    }
}