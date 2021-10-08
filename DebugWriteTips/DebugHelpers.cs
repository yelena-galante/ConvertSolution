using System;
using System.Diagnostics;

namespace DebugWriteTips
{
    public class DebugHelpers
    {
        /// <summary>
        /// Debug.WriteLine append timestamp
        /// </summary>
        /// <param name="sender">Text to write</param>
        public static void WriteLine(string sender)
        {
            if (Debugger.IsAttached)
            {
                Debug.WriteLine($"{sender} | {DateTime.Now:h:mm:ss tt}");
                Console.WriteLine($"{sender} | {DateTime.Now:h:mm:ss tt}");
            }

        }

    }
}