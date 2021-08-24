class arrayProgram
{
    static void Main()
    {
        // string[] languages;
        // int[,] cells;

        //string[] languages = { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };

        // string[] languages;
        // languages = new string[] { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };

        // string[] languages = new string[] { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };

        // string[] languages = new string[9] { "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };

        // string[] languages = new string[9];

        // string [] groceryList;
        // System.Console.Write("How many items on the list?");
        // int size = int.Parse(System.Console.ReadLine());
        // groceryList = new string[size];

        // int[,] cells = new int[3,3];
        // int[,] cells = {
        //     {1,0,2},
        //     {1,2,0},
        //     {1,2,1}
        // };

        // Error: Each dimension must be consistently sized
        // int[,] cells = {
        //     {1,0,2,0},
        //     {1,2,0},
        //     {1,2},
        //     {1}
        // };

        // bool[,,] cells;
        // cells = new bool[2,3,3]
        // {
        //     {{true, false, false},
        //     {true,false,false},
        //     {true,false,true}},

        //     {{false,false,true},
        //     {false,true,false,},
        //     {false,true,true}}
        // }; 

        // int[][] cells = {
        //     new int[] {1,0,2,0},
        //     new int[] {1,2,0},
        //     new int[] {1,2},
        //     new int[] {1}
        // };

        // string[] languages=new string[9]{ "C#", "COBOL", "Java", "C++", "Visual Basic", "Pascal", "Fortran", "Lisp", "J#" };
        // string language = language[4];

        // string language = languages[3];
        // languages[3] = languages[2];
        // languages[2] = language;

        // int[,] cells = {
        //     {1,0,2},
        //     {0,2,0},
        //     {1,2,1}
        // };

        // cells[1,0] = 1;

        // int[][] cells = {
        //     new int[] {1,0,2},
        //     new int[] {0,2,0},
        //     new int[] {1,2,1}
        // };

        // cells[1][0] = 1;

        // string languages = new string[9];

        // System.Console.WriteLine($"There are {languages.Length} languages in the array.");

        // // RUNTIME ERROR: index out of bounds - should
        // // be 8 for the last element
        // languages[4] = languages[8];
        // languages[4] =languages[languages.Length-1];

        bool[,,] cells;
        cells = new bool[2,3,3];
        System.Console.WriteLine(cells.GetLength(0));

        string[] args;
        if(args[0][0] == "-")
        {

        }

        string arg = args[0];
        if(arg[0] == "-")
        {

        }
    }
}