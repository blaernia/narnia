using System;
using System.Collections.Generic;

namespace Narnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Output.Debug = true;

            List<Kid> kids = new List<Kid>();
            kids.Add(new Kid(1));
            kids.Add(new Kid(2));
            kids.Add(new Kid(3));
            kids.Add(new Kid(4));

            for (int n = 0;n<25; n++)
            {
                Console.WriteLine(String.Format("Iteration {0}.", n));
                for (int k = 0; k < 4; k++)
                {
                    kids[k].KickWardrobe();
                    kids[k].OpenWardrobe();
                    kids[k].EnterWardrobe();
                    kids[k].LeaveWardrobe();
                    kids[k].CloseWardrobe();
                }

                PrintState(kids);
            } 
        }

        static void PrintState(List<Kid> kids)
        {

            Console.WriteLine("\nCurrent state:");
            Wardrobe.PrintState();

            for (int k = 0; k < 4; k++)
            {
                kids[k].PrintState();
            }
        }
    }
}
