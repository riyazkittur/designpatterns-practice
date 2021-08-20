using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    public class PublicTransportStrategy : IRouteStrategy
    {
        public void buildRoute()
        {
            Console.WriteLine("Build Public Transport Strategy");
        }
    }
}
