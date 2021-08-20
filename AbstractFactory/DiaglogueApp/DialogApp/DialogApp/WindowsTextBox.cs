using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class WindowsTextBox : ITextBox
    {
        public void OnTextChange()
        {
            Console.WriteLine("Windows textbox type");
        }
    }
}
