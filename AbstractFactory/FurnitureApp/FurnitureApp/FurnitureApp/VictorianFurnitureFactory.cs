using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public  IChair CreateChair()
        {
            return new VictorianChair();
        }

        public  ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
