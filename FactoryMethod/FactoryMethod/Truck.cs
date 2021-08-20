using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Truck: ITransport
    {
        public void TakeOrder()
        {
            Console.WriteLine("Road Transport order placed successfully");
        }
        public void Deliver()
        {
            Console.WriteLine("Road Transport delivery");
        }
        public void CheckStatus()
        {
            Console.WriteLine("Road Transport delivery status is INPROGRESS");
        }
    }
}
