using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
    public class ParkingLotFactory
    {
        public static ParkingLot CreateParkingLot(string parkingLotType)
        {
            ParkingLot parkingLot = null;
            switch (parkingLotType)
            {
                case "2":
                    parkingLot= new TwoWheelerParkingLot();
                    break;
                case "4":
                    parkingLot= new FourWheelerParkingLot();
                    break;
            }
            return parkingLot;
        }
    }
}
