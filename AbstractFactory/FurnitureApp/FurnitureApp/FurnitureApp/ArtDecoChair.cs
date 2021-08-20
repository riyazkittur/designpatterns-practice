using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public class ArtDecoChair : IChair
    {
        public void HasLegs()
        {
            Console.WriteLine("ArtDecoChair has 4 legs");
        }

        public void MaterialDetails()
        {
            Console.WriteLine("ArtDecoChair is made of Teak Wood");
        }
    }
}
