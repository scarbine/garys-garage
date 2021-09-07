using System;

namespace garys_garage.Vehicle
{
    public class Tesla : Vehicle, isElectric
    {
        public double BatteryKwh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesa blazed right by you {MaxiumOccupancey} people in it.Zip a de do dah");
        }
    }
}