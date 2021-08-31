using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Black",
                MaxiumOccupancey = 4,
                BatteryKwh = 175.25
            };
            Zero fx = new Zero()
            {
                MainColor = "Blue",
                MaxiumOccupancey = 4,
                BatteryKwh = 175.25
            };
            Tesla mine = new Tesla()
            {
                MainColor = "Red",
                MaxiumOccupancey = 2,
                BatteryKwh = 250.50
            };
            Cessna c3 = new Cessna()
            {
                MainColor = "White",
                MaxiumOccupancey = 2,
                FuelCapacity = 15.25
            };

            Ram Beast = new Ram(){
                
                MainColor = "Grey",
                MaxiumOccupancey = 2,
                FuelCapacity = 25.25
            };
            List<Zero> electricVehicles = new List<Zero>() { fx , fxs};

            fxs.Drive();
            fx.Drive();
            mine.Drive();
            c3.Drive();
            Beast.Drive();


        }

    }
}
