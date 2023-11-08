using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    class RemoteControlCar
    {

        int distance=0;
        int battery = 100;

        public static RemoteControlCar Buy()
          => new RemoteControlCar();


        public string DistanceDisplay()
            => $"Driven {distance} meters";

        public string BatteryDisplay()
            => battery>0? $"Battery at {battery}%" : "Battery empty";

        public void Drive() 
        {
            if (battery > 0)
            {
                distance += 20;
                battery -= 1;
            }
        }
    }
}
