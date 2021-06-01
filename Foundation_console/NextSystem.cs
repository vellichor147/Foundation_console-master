using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation_console
{
    class NextSystem
    {
        public NextSystem()
        {

        }

        public static void nextSystemMethod()
        {
            Console.WriteLine("Press Enter to scan for new systems...");
            GameManagement.scanMethod();
        }
        

    }
}
