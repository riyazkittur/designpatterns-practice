using System;

namespace DialogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // IDialogfacrory factory = osfactory.GetDialogFactor(osType) --> Factory Method

            DialogWindow window = new DialogWindow(new MacOSDialogFactory());
            window.ShowDialog();

            Console.ReadKey();
        }
    }
}
