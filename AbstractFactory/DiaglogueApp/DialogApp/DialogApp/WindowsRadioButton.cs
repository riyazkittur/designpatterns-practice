using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class WindowsRadioButton : IRadioButton
    {
        public void OnToggle()
        {
            Console.WriteLine("Windows radio button toggled");
        }
    }
}
