using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class WindowsDialogFactory : IDiaglogFactory
    {
        public IButton GetButton()
        {
            return new WindowsButton();
        }

        public IRadioButton GetRadioButton()
        {
            return new WindowsRadioButton();
        }

        public ITextBox GetTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
