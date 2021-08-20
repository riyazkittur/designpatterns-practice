using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class ModernChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("ModernChair has no legs");
        }

        public void MaterialDetails()
        {
            Console.WriteLine("ModernChair has Beech Wood with Breathable Mesh");
        }
    }
}
