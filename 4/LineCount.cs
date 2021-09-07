class LineCount
{
    static void Main()
    {
        int lineCount;
        string files;
        DisplayHelpText();
        files = GetFiles();
        LineCount = CountLines(files);
        DisplayLineCount(lineCount);
    }
}