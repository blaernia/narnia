using System;
using System.Collections.Generic;
using System.Text;

namespace Narnia
{
    static class Housekeeper
    {
        private static int timeout = 2;
        public static void HearsKick(Kid who)
        {
            var rand = new Random();
            int r = rand.Next(1, 10);
            if (r == 5)
            {
                Output.Log(string.Format("Housekeeper: heard kick!!!"));
                who.Timeout(timeout);
            }
        }
    }
}
