using System;

class Program1
{
    static void Main()
    {
        var patent1 =
        new
        {
            Title = "Bifocals",
            YearOfPublication = "1784"
        };
        var patent2 =
        new
        {
            Title = "Phonograph",
            YearOfPublication = "1877"
        };
        var patent3 =
        new
        {
            patent1.Title,
            Year = patent1.YearOfPublication
        };

        System.Console.WriteLine("{0} ({1})", patent1.Title, patent1.YearOfPublication);
        System.Console.WriteLine("{0} ({1})", patent2.Title, patent2.YearOfPublication);

        Console.WriteLine();
        Console.WriteLine(patent1);
        Console.WriteLine(patent2);

        Console.WriteLine();
        Console.WriteLine(patent3);

    }
}