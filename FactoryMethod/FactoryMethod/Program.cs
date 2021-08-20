using System;

namespace FactoryMethod
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");


        //    MySingletonClass firstObject = MySingletonClass.getInstance();
        //    firstObject.Counter = firstObject.Counter + 1;
        //    MySingletonClass secondObject = MySingletonClass.getInstance();
        //    Console.WriteLine($"Second object counter is {secondObject.Counter}");
        //    secondObject.Counter = secondObject.Counter + 1;
        //    MySingletonClass thirdObject = firstObject;

        //    Console.WriteLine($"Third object counter is {thirdObject.Counter}");

        //    Console.ReadKey();
        //}
        static void Main(string[] args)
        {
            string transportType = Console.ReadLine();
            Creator factory = TransportFactory.GetTransportInstance(transportType);
            CallTransportServices(factory);
           
            
            
            //   ITransport transport = TransportFactory.GetTransportInstance(transportType);

            //transport.TakeOrder();
            //transport.Deliver();
            //transport.CheckStatus();


            Console.ReadKey();
        }
        static void CallTransportServices(Creator factory)
        {
            factory.LogisticServices();
        }
    }
}
