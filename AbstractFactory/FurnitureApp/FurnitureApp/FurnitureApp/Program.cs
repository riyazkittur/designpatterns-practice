using System;

namespace FurnitureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Welcome to Furniture World!========");
            FurnitureApplication app = new FurnitureApplication(new ModernFurnitureFactory());
            app.GetFurnitureDetails();
            Console.ReadKey();
        }
    }
}
