using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesAbstractFactory
{
    public interface IAbstractFactory
    {
        public IRectangle GetRectangle();
        public ISquare GetSquare();
    }
}
