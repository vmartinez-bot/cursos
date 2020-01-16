using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Conceptual
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration. Strictly speaking, the Director class is
    // optional, since the client can control builders directly.
    public class Director
    {
        //private IBuilder _builder;

        //public IBuilder Builder
        //{
        //    set { _builder = value; }
        //}

        // The Director can construct several product variations using the same
        // building steps.
        public void makeSportsCar(IBuilder _builder)
        {
            _builder.reset();
            _builder.setSeats(2);
            _builder.setEngine(new SportEngine());
            _builder.setTripComputer();
            _builder.setGPS();
        }

    }
}
