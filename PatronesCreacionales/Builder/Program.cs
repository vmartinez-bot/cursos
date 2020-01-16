using System;
using System.Collections.Generic;

namespace Builder.Conceptual
{             
    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var builder = new CarBuilder();
            var manBuilder = new CarManualBuilder();

      
            Console.WriteLine("Standard basic product:");
            director.makeSportsCar(builder);
            Console.WriteLine(builder.getResult().ListParts());

            Console.WriteLine("Manual of product:");
            director.makeSportsCar(manBuilder);
            Console.WriteLine(manBuilder.getResult().ListParts());

          
        }
    }
}