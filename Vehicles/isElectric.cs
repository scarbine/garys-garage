using System;

namespace garys_garage.Vehicle
{
    public interface isElectric
    {
        public double BatteryKwh { get; set; }

        public int CurrentChargePercentage { get; set;}

        public void ChargeBattery()
        {

        }
    }
}