using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Aeroplane : ITransport
    {
        public void TakeOrder()
        {
            Console.WriteLine("Air Transport order placed successfully");
        }
        public void Deliver()
        {
            Console.WriteLine("Air Transport delivery");
        }
        public void CheckStatus()
        {
            Console.WriteLine("Air Transport delivery status is INPROGRESS");
        }
    }
}
