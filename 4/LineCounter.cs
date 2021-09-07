using System.IO;

public static class LineCounter
{
    public static void Main(string[] args)
    {
        int totalLineCount = 0;
        string directory;
        if(args.Length>0)
        {
            directory = args[0];
        }
        else
        {
            directory = Directory.GetCurrentDirectory();
        }
        totalLineCount = DirectoryCountLines(directory);
        System.Console.WriteLine(totalLineCount);
    }

    static int DirectoryCountLines(string directory)
    {
        int LineCounter = 0;
        foreach (string file in Directory.GetFiles(directory, "*.cs"))
        {
            LineCounter += DirectoryCountLines(file);
        }

        foreach (string subdirectory in Directory.GetDirectories(directory))
        {
            LineCounter += DirectoryCountLines(subdirectory);
        }
        return LineCounter;
    }

    private static int CountLines(string file)
    {
        string line;
        int lineCount = 0;
        FileStream stream = new FileStream(file, FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        line = reader.ReadLine();

        while(line != null)
        {
            if(line.Trim() != "")
            {
                lineCount++;
            }
            line = reader.ReadLine();
        }

        reader.Close();
        return lineCount;
    }
}