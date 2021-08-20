using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class ModernSofa : ISofa
    {
        public void GetSeatingCapacity()
        {
            Console.WriteLine("ModernSofa has 3+1 seating capacity");
        }

        public void SofaDetails()
        {
            Console.WriteLine("ModernSofa is LHS sectional sofa");   
        }
    }
}
