using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
   public interface ITransport
    {
        void TakeOrder();
        void Deliver();
        void CheckStatus();
    }
}
