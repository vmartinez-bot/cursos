using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Conceptual
{

    // Each Concrete Factory has a corresponding product variant.
    class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }

        public IRadioButton CreateRadioButton() {
            return new MacRadioButton();
        }
    }

}
