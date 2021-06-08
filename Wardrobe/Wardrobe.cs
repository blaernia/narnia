using System;
using System.Collections.Generic;
using System.Text;

namespace Narnia
{
    static class Wardrobe
    {
        public static List<Kid> KidsInside = new List<Kid>();
        private static bool _doorIsOpen { get; set; }
        private static bool _doorIsLocked { get; set; }
        
        private static Random rand = new Random();

        public static void PrintState()
        {
            Console.WriteLine(string.Format("Wardobe: door is {0} and {1}.", _doorIsOpen ? "Open" : "Closed", _doorIsLocked ? "Locked" : "Unlocked"));
        }
        public static bool  IsDoorOpen()
        {
            return _doorIsOpen;
        }

        public static bool IsDoorLocked()
        {
            return _doorIsLocked;

        }


        private static void LockDoor()
        {
            if (!IsDoorOpen())
            {
                _doorIsLocked = true;
            }
        }
        public static bool OpenDoor(Kid who)
        {
            if (!_doorIsLocked)
            {
                _doorIsOpen = true;
                Output.Log(string.Format("Wardobe: door was openend by {0}.", who.id));
            } else
            {
                Output.Log(string.Format("Wardrobe: door is locked. Can\'t be opened by {0}", who.id));
            }
            return IsDoorOpen();
        }

        public static bool Enter(Kid who)
        {
           
            if (IsDoorOpen())
            {
                who.IsInTheWardrobe = true;
                Output.Log(string.Format("Wardrobe: {0} entered.", who.id));
                return true;
            } else
            {
                Output.Log(string.Format("Wardrobe: {0} cannot enter because the door is closed", who.id));
                return false;
            }
        }

        public static bool Leave(Kid who)
        {
            if (IsDoorOpen())
            {
                who.IsInTheWardrobe = false;
                Output.Log(string.Format("Wardrobe: {0} left", who.id));
                return true;
            } else
            {
                Output.Log(string.Format("Wardrobe: {0} cannot leave because the door is closed", who.id));
                return false;
            }
        }

        public static bool CloseDoor(Kid who)
        {
            _doorIsOpen = false;
            LockDoor();
            Output.Log(string.Format("Wardobe: door was closed by {0}.", who.id));
            return _doorIsOpen;
        }

        public static void Kick(Kid who)
        {
            Output.Log(string.Format("Wardobe: was kicked by {0}.", who.id));

            int r = rand.Next(1, 3);
            if (r == 2)
            {
                _doorIsLocked = false;
                Output.Log(string.Format("Wardrobe: Wardrobe was unlocked!"));
            }

            Housekeeper.HearsKick(who);
            
        }
    }
}
