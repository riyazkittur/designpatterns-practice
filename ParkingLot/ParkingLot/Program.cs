using System;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string parkingLotType = Console.ReadLine();

            ParkingLot parking = ParkingLotFactory.CreateParkingLot(parkingLotType);
            if (parking == null)
            {
                Console.WriteLine("Vehicle not allowed");
            }
            else
            {
                parking.CalculateParkingFee();
            }
            Console.ReadKey();

        }
    }
}
