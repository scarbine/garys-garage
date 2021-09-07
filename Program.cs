using System;
using System.Collections.Generic;
using garys_garage.Vehicle;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();



            List <isElectric> electricVehicles = new List<isElectric> () {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (isElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (isElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (isElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
                
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List <isGas> gasVehicles = new List<isGas> () {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (isGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (isGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (isGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
