using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;

namespace EnjoyTest
{
    class HelperApi
    {
        //start console 
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();
        //free console
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();

        [DllImport("User32.dll ", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll ", EntryPoint = "GetSystemMenu")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, IntPtr bRevert);

        [DllImport("user32.dll ", EntryPoint = "RemoveMenu")]
        public static extern int RemoveMenu(IntPtr hMenu, int nPos, int flags);

        public class ConsoleShow
        {
            public static bool consoleState = false;
            ~ConsoleShow()
            {
                //FreeConsole();
            }
            public bool CsAllocConsole()
            {
                consoleState = true;
                return AllocConsole();
            }
            public bool CsFreeConsole()
            {
                consoleState = false;
                return FreeConsole();
            }

        }

    }
}
