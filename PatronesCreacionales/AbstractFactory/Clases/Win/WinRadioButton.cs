using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Conceptual
{
    class WinRadioButton : IRadioButton
    {
        string IRadioButton.UsefulFunctionC()
        {
            return "Este es un radio button de Windows";
        }
    }
}
