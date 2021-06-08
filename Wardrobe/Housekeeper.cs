using System;
using System.Collections.Generic;
using System.Text;

namespace Narnia
{
    static class Housekeeper
    {
        private static Random rand = new Random();
        private static int timeout = 2;
        public static void HearsKick(Kid who)
        {
            int r = rand.Next(1, 10);
            if (r == 5)
            {
                Output.Log(string.Format("Housekeeper: heard kick!!!"));
                who.Timeout(timeout);
            }
        }
    }
}
