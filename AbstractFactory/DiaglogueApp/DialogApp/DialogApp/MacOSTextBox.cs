using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class MacOSTextBox : ITextBox
    {
        public void OnTextChange()
        {
            Console.WriteLine("Mac OS textbox type");
        }
    }
}
