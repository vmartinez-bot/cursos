using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Conceptual
{

    class MacCheckbox : ICheckbox
    {
        public string UsefulFunctionB()
        {
            return "The result of the product Mac Checkbox.";
        }

        // The variant, Product B2, is only able to work correctly with the
        // variant, Product A2. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IButton collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }
    }
}
