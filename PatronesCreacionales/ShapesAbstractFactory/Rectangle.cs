using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesAbstractFactory
{
    public class Rectangle : IRectangle
    {
        public double width { get; set; }
        public double height { get; set; }
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle with area={0}", GetArea());
        }

        public double GetArea()
        {
            return width * height;
        }
    }
}
