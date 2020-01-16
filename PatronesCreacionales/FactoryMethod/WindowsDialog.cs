﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Conceptual
{
    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    class WindowsDialog : Dialog
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override IButton createButton()
        {
            return new WindowsButton();
        }
    }
}
