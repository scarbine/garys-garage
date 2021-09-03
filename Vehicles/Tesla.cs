using System;

namespace garys_garage.Vehicle
{
    public class Tesla : isElectric
    {
        public double BatteryKwh { get; set; }

        public void ChargeBattery()
        {

        }

        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesa blazed right by you {MaxiumOccupancey} people in it.Zip a de do dah");
        }
    }
}