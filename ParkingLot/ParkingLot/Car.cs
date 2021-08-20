using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class Car : IVehicle
    {
        public void CalculateParkingFee()
        {
            Console.WriteLine("Calculted Car Parking Fee");
        }
    }
}
