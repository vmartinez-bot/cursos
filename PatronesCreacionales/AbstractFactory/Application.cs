using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Conceptual
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    class Application
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new MacFactory());
        }

        public void ClientMethod(IGUIFactory factory)
        {
            var productA = factory.CreateButton();
            var productB = factory.CreateCheckbox();
            var productC = factory.CreateRadioButton();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
            Console.WriteLine(productC.UsefulFunctionC());
        }
    }

}
