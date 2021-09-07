using System;

namespace garys_garage.Vehicle
{
    public class Cessna : Vehicle , isGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }


        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna zips by you {MaxiumOccupancey} people in it. Zooooooooom!");
        }
    }
}