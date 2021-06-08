using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Narnia
{
    class Kid
    {
        public bool IsInTheWardrobe { get; set; }
        public int id { get; }

        public void PrintState()
        {
            Console.WriteLine(string.Format("Kid {0}: is {1} in the wardrobe.", this.id, IsInTheWardrobe ? "" : "not"));
        }
        public Kid(int id)
        {
            this.id = id;
            Output.Log(string.Format("Kid {0}: born.", this.id));
        }
       
        public void Timeout(int s)
        {
            Output.Log(string.Format("Kid {0}: Got a timeout of {1} seconds.", this.id, s));
            
            Task.Delay(1000 * s).Wait();
        }
        public void KickWardrobe()
        {
            Output.Log(string.Format("Kid {0}: kicks wardrobe.", id));
            Wardrobe.Kick(this);
            
        }

        public bool OpenWardrobe()
        {
            bool canOpen = Wardrobe.OpenDoor(this);
            if (canOpen)
            {
                Output.Log(string.Format("Kid {0}: opens wardrobe.", id));
            } else
            {
                Output.Log(string.Format("Kid {0}: can\'t open wardrobe. It's locked.", id));
            }
            
            return canOpen;
        }

        public void CloseWardrobe()
        {
            Output.Log(string.Format("Kid {0}: closes wardrobe.", id));
            Wardrobe.CloseDoor(this);
        }

        public void EnterWardrobe()
        {
            if (Wardrobe.IsDoorOpen()) { 
                Output.Log(string.Format("Kid {0}: enters wardrobe.", id));
                Wardrobe.Enter(this);
            } else
            {
                Output.Log(string.Format("Kid {0}: Can\'t enter wardrobe. It\'s closed.", id));
            }
        }

        public void LeaveWardrobe()
        {
            if (Wardrobe.IsDoorOpen())
            {
                Output.Log(string.Format("Kid {0}: leaves wardrobe.", id));
                Wardrobe.Leave(this);
            } else
            {
                Output.Log(string.Format("Kid {0}: Can\'t leave wardrobe. It\'s closed.", id));
            }
        }
    }
}
