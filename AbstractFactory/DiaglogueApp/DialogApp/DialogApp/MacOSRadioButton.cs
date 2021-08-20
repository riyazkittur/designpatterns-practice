using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class MacOSRadioButton : IRadioButton
    {
        public void OnToggle()
        {
            Console.WriteLine("Mac OS radio button toggled");
        }
    }
}
