using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingProject
{
    class RemoteControlCar
    {
        int speed;
        int batteryDrain;
        int batteryCharge = 100;
        int distanceDriven = 0;

        public int Speed { get => speed; set => speed = value; }
        public int BatteryDrain { get => batteryDrain; set => batteryDrain = value; }
        public int BatteryCharge { get => batteryCharge; set => batteryCharge = value; }

        public RemoteControlCar(int speed, int battery_drain)
        {
            Speed = speed;
            BatteryDrain = battery_drain;
        }

        public bool BatteryDrained()
            => batteryCharge < batteryDrain ? true : false;

        public int DistanceDriven()
            => distanceDriven;

        public void Drive()
        {
            if (!BatteryDrained())
            {
                distanceDriven += Speed;
                batteryCharge -= BatteryDrain;
            }
        }

        public static RemoteControlCar Nitro()
            => new RemoteControlCar(50, 4);
    }

    class RaceTrack
    {
        int distance;

        public RaceTrack(int dis)
        {
            distance = dis;
        }

        public bool TryFinishTrack(RemoteControlCar car)
        {
            int necessaryDrives = ((distance % car.Speed) == 0) ? distance / car.Speed : distance / car.Speed + 1;

            return necessaryDrives * car.BatteryDrain <= 100 ? true : false;
        }
    }
}
