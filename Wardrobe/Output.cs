using System;
using System.Collections.Generic;
using System.Text;

namespace Narnia
{
    static class Output
    {
        public static bool Debug { get; set; }
        public static void Log(string s)
        {
            if (Debug)
            {
                Console.WriteLine(s);
            }
        }
    }
}
