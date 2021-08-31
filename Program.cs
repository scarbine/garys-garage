using System;
using System.Collections.Generic;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla mine = new Tesla();
            Cessna c3 = new Cessna();
            List<Zero> electricVehicles = new List<Zero>() { fx , fxs};

            fxs.Drive();
            fx.Drive();
            mine.Drive();
            c3.Drive();


        }

    }
}
