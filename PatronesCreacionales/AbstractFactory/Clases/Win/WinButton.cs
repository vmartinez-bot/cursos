using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Conceptual
{
    // Concrete Products are created by corresponding Concrete Factories.
    class WinButton : IButton
    {
        public string UsefulFunctionA()
        {
            return "The result of the product Win BUTTON.";
        }
    }
}
