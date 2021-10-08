using System;
using System.Diagnostics;
using System.IO;

namespace DebugWriteTips
{
    /// <summary>
    /// Several tips when using Debug methods
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            if (Debugger.IsAttached)
            {
                DebugHelpers.WriteLine("Hello");
                Console.WriteLine("Debugger attached");
            }
            else
            {
                Console.WriteLine("Debugger is not attached");
            }

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        private static void WriteLineIf()
        {
            Debug.WriteLineIf(DateTime.Now.DayOfWeek == DayOfWeek.Friday, "Happy Friday");
            Debug.WriteLineIf(Directory.Exists("C:\\OED"), "Folder exists");
            Debug.WriteLineIf(!Directory.Exists("C:\\OEDQ"), "Folder does not exists");
        }

        private static void IndentLevel()
        {
            Debug.WriteLine($"Starting {nameof(IndentLevel)}");
            Debug.Indent();

            for (int index = 0; index < 10; index++)
            {
                if ((index % 2) == 0)
                {
                    Debug.Indent();
                }

                if ((index % 3) == 0)
                {
                    Debug.Unindent();
                }

                Debug.WriteLine($"Loop {index} at Indent Level {Debug.IndentLevel}");
            }

            Debug.IndentLevel = 0;
            Debug.WriteLine($"Ending {nameof(IndentLevel)}");
        }
    }
}