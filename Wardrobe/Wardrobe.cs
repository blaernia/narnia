using System;
using System.Collections.Generic;
using System.Text;

namespace Narnia
{
    static class Wardrobe
    {
        public static List<Kid> KidsInside = new List<Kid>();
        private static bool _doorIsOpen { get; set; }

        public static void PrintState()
        {
            Console.WriteLine(string.Format("Wardobe: door is {0}.", _doorIsOpen ? "Open" : "Closed" ));
        }

        public static bool  IsDoorOpen()
        {
            return _doorIsOpen;
        }
        public static bool OpenDoor(Kid who)
        {
            _doorIsOpen = true;
            Output.Log(string.Format("Wardobe: door was openend by {0}.", who.id));
            return _doorIsOpen;
        }

        public static void Enter(Kid who)
        {
           
            if (_doorIsOpen)
            {
                
                Output.Log(string.Format("Wardrobe: {0} entered.", who.id));
            } else
            {
                Output.Log(string.Format("Wardrobe: {0} cannot enter because the door is closed", who.id));
            }
        }

        public static void Leave(Kid who)
        {
            if (_doorIsOpen)
            {
                
                Output.Log(string.Format("Wardrobe: {0} left", who.id));
            } else
            {
                Output.Log(string.Format("Wardrobe: {0} cannot leave because the door is closed", who.id));
            }
        }

        public static bool CloseDoor(Kid who)
        {
            _doorIsOpen = false;
            Output.Log(string.Format("Wardobe: door was closed by {0}.", who.id));
            return _doorIsOpen;
        }

        public static void Kick(Kid who)
        {
            Housekeeper.HearsKick(who);
            Output.Log(string.Format("Wardobe: was kicked by {0}.", who.id));
        }
    }
}
