using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class VictorianChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("VictorianChair has 4 legs");
        }

        public void MaterialDetails()
        {
            Console.WriteLine("VictorianChair has Oak Wood with Leather finish");
        }
    }
}
