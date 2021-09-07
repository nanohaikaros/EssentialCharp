// class Program 
// {
//     static void Main()
//     {
//         // System.Console.Write("Enter your first name: ");
//         // System.Console.WriteLine("Hello {0}!", System.Console.ReadLine());

//     }

//     static bool MyMethod()
//     {
//         string command = ObtainCommand();
//         switch(command)
//         {
//             case "quit":
//                 return false;
//             default:
//                 return true;
//         }
//     }
// }

// using System;
// using System.IO;
// using System.Net;

// class Program
// {
//     static int Main(string[] args)
//     {
//         int result;
//         string targetFileName;
//         string url;
//         switch (args.Length)
//         {
//             default:
//                 // Exactly two arguments must be specified; five an error.
//                 Console.WriteLine(
//                     "ERROR: Youmust specify the "
//                     + "URL and the file name"
//                 );
//                 targetFileName = null;
//                 url = null;
//                 break;
//             case 2:
//                 url = args[0];
//                 targetFileName = args[1];
//                 break;
//         }

//         if (targetFileName != null && url != null)
//         {
//             WebClient webClient = new WebClient();
//             webClient.DownloadFile(url, targetFileName);
//             result = 0;
//         }
//         else
//         {
//             Console.WriteLine("Usage: Downloader.exe <URL> <TargetFileName>");
//             result = 1;
//         }
//         return result;
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         string fullName;
//         string driveLetter = "C:";
//         string folderPath = "Data";
//         string fileName = "index.html";

//         fullName = Combine(driveLetter, folderPath, fileName);

//         Console.WriteLine(fullName);
//     }

//     static string Combine(string driveLetter, string folderPath, string fileName)
//     {
//         string path;
//         path = string.Format("{1}{0}{2}{0}{3}", System.IO.Path.DirectorySeparatorChar, driveLetter, folderPath, fileName);
//     }
// }

using System;

class Program
{
    static void Main()
    {
        string first = "hello";

        string second = "goodbye";
        Swap(ref first, ref second);

        Console.WriteLine($@"first = ""{first}"", second = ""{second}""");
    }

    static void Swap(ref string x, ref string y)
    {
        string temp = x;
        x = y;
        y = temp;
    }
}