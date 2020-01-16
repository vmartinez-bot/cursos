using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Conceptual
{
    // The Concrete Builder classes follow the Builder interface and provide
    // specific implementations of the building steps. Your program may have
    // several variations of Builders, implemented differently.
    public class CarBuilder : IBuilder
    {
        private Car _product = new Car();

        // A fresh builder instance should contain a blank product object, which
        // is used in further assembly.
        public CarBuilder()
        {
            this.reset();
        }

        public void reset()
        {
            this._product = new Car();
        }



        // Concrete Builders are supposed to provide their own methods for
        // retrieving results. That's because various types of builders may
        // create entirely different products that don't follow the same
        // interface. Therefore, such methods cannot be declared in the base
        // Builder interface (at least in a statically typed programming
        // language).
        //
        // Usually, after returning the end result to the client, a builder
        // instance is expected to be ready to start producing another product.
        // That's why it's a usual practice to call the reset method at the end
        // of the `GetProduct` method body. However, this behavior is not
        // mandatory, and you can make your builders wait for an explicit reset
        // call from the client code before disposing of the previous result.
        public Car getResult()
        {
            Car result = this._product;

            this.reset();

            return result;
        }

        

        public void setSeats(int number)
        {
            this._product.Add( "Seats: "+ number+"");
        }

        public void setEngine(IEngine engine)
        {
            this._product.Add("Engine: " + engine.TestEngine ());
        }

        public void setTripComputer()
        {
            this._product.Add("Trip Computer");
        }

        public void setGPS()
        {
            this._product.Add("GPS Advanced");
        }
    }
}
