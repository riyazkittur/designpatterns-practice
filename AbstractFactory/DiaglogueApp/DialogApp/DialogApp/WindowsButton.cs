using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class WindowsButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Windows button clicked");
        }
    }
}
