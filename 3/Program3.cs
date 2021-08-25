class Program3
{
    static void Main(string[] args)
    {
        bool isOutputSet = false;
        bool isFiltered = false;
        bool isRecursive = false;

        foreach (string option in args)
        {
            switch (option)
            {
                case "/out":
                    isOutputSet = true;
                    isFiltered = false;
                    goto default;
                case "/f":
                    isFiltered = true;
                    isRecursive = false;
                    goto default;
                default:
                    if (isRecursive) {}
                    else if (isFiltered) {}
                    break;
            }
        }
    }
}