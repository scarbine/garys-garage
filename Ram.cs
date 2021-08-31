using System;

namespace garys_garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram just ran over you {MaxiumOccupancey} people in it. Ouch!");
        }
    }
}