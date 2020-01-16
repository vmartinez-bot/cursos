using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Conceptual
{
    // Each distinct product of a product family should have a base interface.
    // All variants of the product must implement this interface.
    public interface IButton
    {
        string UsefulFunctionA();
    }

}
