using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class ArtDecoSofa : ISofa
    {
        public void GetSeatingCapacity()
        {
            Console.WriteLine("ArtDecoSofa has 3 seating capacity");
           
        }

        public void SofaDetails()
        {
            Console.WriteLine("ArtDecoSofa has wood carvings in light yellow color");
        }
    }
}
