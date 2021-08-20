using System;

namespace Navigator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NavigatorContext context = new NavigatorContext();


            //factory method pattern to identify the strategy based on user selection

            context.SetRouteStrategy(new RoadStrategy());
            context.buildRoute();
            Console.ReadKey();
        }
    }
}
