using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class TransportFactory
    {
        public static Creator GetTransportInstance(string transportType)
        {
            switch (transportType.ToLower())
            {
                case "sea":
                    return new SeaLogistics();
                case "road":
                    return new RoadLogistics();
                case "air":
                    return new AirLogistics();
                default:
                    return null;

            }
        }
    }
}
