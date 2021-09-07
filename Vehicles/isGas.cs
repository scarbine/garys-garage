using System;

namespace garys_garage.Vehicle
{
    public interface isGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage {get; set;}


        public void RefuelTank()
        {

        }
    }
}