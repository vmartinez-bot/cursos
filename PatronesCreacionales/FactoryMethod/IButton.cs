using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Conceptual
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IButton
    {
        string Operation();
    }
}
