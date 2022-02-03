using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

namespace PrimitierModManager.MelonLoader
{
    internal static class ThreadHandler
    {

    
        internal delegate void RecursiveFuncRecurse();
        internal delegate void RecursiveFuncVoid(RecursiveFuncRecurse recurse);
        internal static void RecursiveFuncRun(RecursiveFuncVoid func)
        {
            if (func == null)
                return;
            func.Invoke(delegate () { RecursiveFuncRun(func); });
        }
    }
}
