using System;

namespace garys_garage.Vehicle
{
    public class Ram : Vehicle, isGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }


        public void RefuelTank()
        {

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram just ran over you {MaxiumOccupancey} people in it. Ouch!");
        }
    }
}