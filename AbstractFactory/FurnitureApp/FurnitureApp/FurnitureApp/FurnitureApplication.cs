using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class FurnitureApplication
    {
        public IFurnitureFactory Factory;
        public FurnitureApplication(IFurnitureFactory factory)
        {
           Factory = factory;
        }

        public void GetFurnitureDetails()
        {
            IChair chair = Factory.CreateChair();
            chair.HasLegs();
            chair.MaterialDetails();
            ISofa sofa = Factory.CreateSofa();
            sofa.SofaDetails();
            sofa.GetSeatingCapacity();
            
        }
    }
}
