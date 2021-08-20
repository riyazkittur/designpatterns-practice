using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot
{
   public abstract class ParkingLot
    {
        public IVehicle Vehicle;
        public abstract IVehicle GetVehicle();
        public void CalculateParkingFee()
        {
            Vehicle = GetVehicle();
            Vehicle.CalculateParkingFee();
        }
    }

    public class TwoWheelerParkingLot : ParkingLot
    {
        public override IVehicle GetVehicle()
        {
            return new Bike();
        }
    }
    public class FourWheelerParkingLot : ParkingLot
    {
        public override IVehicle GetVehicle()
        {
            return new Car();
        }
    }
}
