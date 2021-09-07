using System;
using System.IO;

class PathEx
{
    static void Main()
    {
        string fullName;

        fullName = Combine(Directory.GetCurrentDirectory(),
        "bin", "config", "index.html");
        Console.WriteLine(fullName);

        fullName = Combine(Environment.SystemDirectory,
        "Temp", "index.html");
        Console.WriteLine(fullName);

        fullName = Combine(new string[] {
            "C:\\", "Data",
            "HomeDir", "index.html"
        });
        Console.WriteLine(fullName);
    }

    static string Combine(params string[] paths)
    {
        string result = string.Empty;
        foreach (string path in paths)
        {
            result = System.IO.Path.Combine(result, path);
        }
        return result;
    }
}