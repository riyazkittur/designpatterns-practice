using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Creator
    {
        public ITransport Transport;
       
        public abstract ITransport GetTransportInstance();

        public  void LogisticServices()
        {
            Transport = GetTransportInstance();
            Transport.TakeOrder();
            Transport.Deliver();
            Transport.CheckStatus();
        }

        //public static ITransport GetTransportInstance(string transportType)
        //{
        //    switch (transportType.ToLower())
        //    {
        //        case "sea":
        //            return new SeaTransport();
        //        case "road":
        //            return new RoadTransport();
        //        default:
        //            return null;

        //    }
        //}
    }

    public class RoadLogistics : Creator
    {
        public override ITransport GetTransportInstance()
        {
            return new Truck();
        }
    }

    public class SeaLogistics : Creator
    {
        public override ITransport GetTransportInstance()
        {
            return new Ship();
        }
    }
    public class AirLogistics: Creator
    {
        public override ITransport GetTransportInstance()
        {
            return new Aeroplane();
        }
    }
}
