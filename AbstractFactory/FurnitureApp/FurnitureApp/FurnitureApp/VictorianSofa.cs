using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class VictorianSofa : ISofa
    {
        public void GetSeatingCapacity()
        {
            Console.WriteLine("VictoriaSofa has 6 seating capacity");
        }

        public void SofaDetails()
        {
            Console.WriteLine("VictoriaSofa has Teak wood with leather finishing");
        }
    }
}
