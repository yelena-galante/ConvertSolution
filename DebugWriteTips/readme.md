
### Tips on Debug methods

- [x] Any Debug.Write, Debut.WriteLine, Debug.WriteLineIf need to be removed for a production build 
- [x] Create wrappers e.g. add a timestamp
  - [x] Make sure not used in production

```csharp
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
```
