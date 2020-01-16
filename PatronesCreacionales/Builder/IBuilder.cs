using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Conceptual
{
    // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void reset();

        void setSeats(int number);

        void setEngine(IEngine engine);


        void setTripComputer();

        void setGPS();
    }
}
