using System;

namespace garys_garage.Vehicle
{
    public class Ram : isGas
    {
        public double FuelCapacity { get; set; }


        public void RefuelTank()
        {

        }

        public void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram just ran over you {MaxiumOccupancey} people in it. Ouch!");
        }
    }
}