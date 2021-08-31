using System;

namespace garys_garage
{
    public class Zero : Vehicle
    {
        public double BatteryKwh { get; set; }


    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero just Zipped by you with {MaxiumOccupancey} people in it! Voooooooom!");
    }
    }
}