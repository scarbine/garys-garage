using System;

namespace garys_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaxiumOccupancey { get; set; }


        public virtual void Drive()
        {
            Console.WriteLine("Vrooooom!");
        }
    }
}