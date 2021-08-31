using System;

namespace garys_garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity {get; set;}


        public void ChargeBattery()
        {

        }

       public override void Drive()
       {
           Console.WriteLine($"The {MainColor} Cessna zips by you {MaxiumOccupancey} people in it. Zooooooooom!");
       }
    }
}