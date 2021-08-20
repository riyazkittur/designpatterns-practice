using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
    public interface IDiaglogFactory
    {
        ITextBox GetTextBox();
        IButton GetButton();

        IRadioButton GetRadioButton();
    }


}
