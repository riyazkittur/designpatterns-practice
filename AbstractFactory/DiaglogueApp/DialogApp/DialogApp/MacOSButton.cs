using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class MacOSButton : IButton
    {
        public void OnClick()
        {
            Console.WriteLine("Mac OS button clicked");
        }
    }
}
