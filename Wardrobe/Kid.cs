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

        public void OpenWardrobe()
        {
            Output.Log(string.Format("Kid {0}: opens wardrobe.", id));
            Wardrobe.OpenDoor(this);
        }

        public void CloseWardrobe()
        {
            Output.Log(string.Format("Kid {0}: closes wardrobe.", id));
            Wardrobe.CloseDoor(this);
        }

        public void EnterWardrobe()
        {
            Output.Log(string.Format("Kid {0}: enters wardrobe.", id));
            Wardrobe.Enter(this);
        }

        public void LeaveWardrobe()
        {

           Output.Log(string.Format("Kid {0}: leaves wardrobe.", id));
           Wardrobe.Leave(this);
        }
    }
}
