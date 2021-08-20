using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class Bike : IVehicle
    {
        public void CalculateParkingFee()
        {
            Console.WriteLine("Calculted Bike Parking Fee");
        }
    }
}
