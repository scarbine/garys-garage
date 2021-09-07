using System;

namespace garys_garage.Vehicle
{
    public class Zero : Vehicle, isElectric
    {
        public double BatteryKwh { get; set; }

        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero just Zipped by you with {MaxiumOccupancey} people in it! Voooooooom!");
        }
    }
}