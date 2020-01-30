using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesAbstractFactory
{
    class RoundedShapeFactory : IAbstractFactory
    {
        public IRectangle GetRectangle()
        {
            return new RoundedRectangle();
        }

        public ISquare GetSquare()
        {
            return new RoundedSquare();
        }
    }
}
