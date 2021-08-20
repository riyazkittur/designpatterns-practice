using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
   public class NavigatorContext
    {
        public IRouteStrategy Route;
        public NavigatorContext()
        {
            
        }
        public void SetRouteStrategy(IRouteStrategy routeStrategy)
        {
            Route = routeStrategy;
        }
        public void buildRoute()
        {
            Route.buildRoute();
        }
    }
}
