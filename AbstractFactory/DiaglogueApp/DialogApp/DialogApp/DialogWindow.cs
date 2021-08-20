using System;
using System.Collections.Generic;
using System.Text;

namespace DialogApp
{
   public  class DialogWindow
    {
        public IDiaglogFactory diaglogFactory;
        public DialogWindow(IDiaglogFactory factory)
        {
            diaglogFactory = factory;
        }
        public void ShowDialog()
        {
            var button = diaglogFactory.GetButton();
            button.OnClick();

            var textBox = diaglogFactory.GetTextBox();
            textBox.OnTextChange();

            var radioButton = diaglogFactory.GetRadioButton();
            radioButton.OnToggle();
        }
    }
}
