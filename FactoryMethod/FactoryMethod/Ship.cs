using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Ship:ITransport
    {
        public void TakeOrder()
        {
            Console.WriteLine("Sea Transport order placed successfully");
        }
        public void Deliver()
        {
            Console.WriteLine("Sea Transport delivery");
        }
        public void CheckStatus()
        {
            Console.WriteLine("Sea Transport delivery status is INPROGRESS");
        }
    }
}
