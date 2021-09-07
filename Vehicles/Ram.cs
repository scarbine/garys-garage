using System;

namespace garys_garage.Vehicle
{
    public class Ram : Vehicle, isGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; } = 50;


        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram just ran over you {MaxiumOccupancey} people in it. Ouch!");
        }
    }
}