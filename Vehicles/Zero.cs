using System;

namespace garys_garage.Vehicle
{
    public class Zero : isElectric
    {
        public double BatteryKwh { get; set; }
        public void ChargeBattery()
        {

        }

        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero just Zipped by you with {MaxiumOccupancey} people in it! Voooooooom!");
        }
    }
}