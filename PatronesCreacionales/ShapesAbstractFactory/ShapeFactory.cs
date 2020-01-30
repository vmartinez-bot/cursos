using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesAbstractFactory
{
    public class ShapeFactory : IAbstractFactory
    {
        public IRectangle GetRectangle()
        {
            return new Rectangle();
        }

        public ISquare GetSquare()
        {
            return new Square();
        }
    }
}
