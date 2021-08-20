using System;

namespace XMLToJSONAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            XMLService adaptee = new XMLService();
            ITarget target = new JSONAdapter(adaptee);
           var ouput= target.GetJSONFormatData();
            Console.WriteLine($"JSON data \n {ouput}");
            Console.ReadKey();
        }
    }
}
