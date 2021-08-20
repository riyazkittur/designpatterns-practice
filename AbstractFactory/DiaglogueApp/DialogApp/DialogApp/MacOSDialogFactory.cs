using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public class MacOSDialogFactory : IDiaglogFactory
    {
        public IButton GetButton()
        {
            return new MacOSButton();
        }

        public IRadioButton GetRadioButton()
        {
            return new MacOSRadioButton();
        }

        public ITextBox GetTextBox()
        {
            return new MacOSTextBox();
        }
    }
}
