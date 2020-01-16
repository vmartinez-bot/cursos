using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Conceptual
{
    // Concrete Products provide various implementations of the Product
    // interface.
    class WindowsButton : IButton
    {
        public string Operation()
        {
            return "{Result of windowsButton}";
        }
    }
}
