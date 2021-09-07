// The using directive imports all types from the
// specified namespace into the entire file
// namespace EssentialCSharp
// {
//    using System;

//     class HelloWorld
//     {
//         static void Main()
//         {
//             // No need to qualify Console with System
//             // because of the using directive above.
//             Console.WriteLine("Hello, my name is Inigo Montoya");
//         }
//     } 
// }

using System;
using System.Threading;

// using CountDownTimer = System.Timers.Timer;
using Timer = System.Timers.Timer;

class HelloWorld
{
    static void Main()
    {
        // CountDownTimer timer;
        Timer timer;
    }
}

