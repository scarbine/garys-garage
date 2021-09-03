using System;

namespace garys_garage.Vehicle
{
    public class Cessna : isGas
    {
        public double FuelCapacity {get; set;}


        public void ChargeBattery()
        {

        }

       public void Drive()
       {
           Console.WriteLine($"The {MainColor} Cessna zips by you {MaxiumOccupancey} people in it. Zooooooooom!");
       }
    }
}