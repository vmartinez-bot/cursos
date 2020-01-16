using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Conceptual
{
    class CarManualBuilder : IBuilder
    {
        private Manual _product = new Manual();

        public CarManualBuilder() {
            this.reset();
        }

        public Manual getResult() {
            Manual result = this._product;

            this.reset();

            return result;
        }

        public void reset()
        {
            this._product = new Manual();
        }

        public void setEngine(IEngine engine)
        {
            this._product.Add("Engine Manual: " + engine.TestEngine());
        }

        public void setGPS()
        {
            this._product.Add("GPS Manual");
        }

        public void setSeats(int number)
        {
            this._product.Add(number + " Seats Manual");
        }

        public void setTripComputer()
        {
            this._product.Add("Trip Computer Manual");
        }
    }
}
