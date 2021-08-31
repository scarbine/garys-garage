using System;

namespace garys_garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesa blazed right by you {MaxiumOccupancey} people in it.Zip a de do dah");
        }
    }
}