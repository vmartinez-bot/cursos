using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Conceptual
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new WindowsDialog());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new WebDialog());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(Dialog creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
            // ...
        }
    }
}
