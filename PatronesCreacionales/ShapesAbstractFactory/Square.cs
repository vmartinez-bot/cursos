using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesAbstractFactory
{
    public class Square : ISquare
    {
        public double width { get; set; }
        public double height { get; set; }
        public void Draw()
        {
            Console.WriteLine("Drawing Square with area={0}", GetArea());
        }

        public double GetArea()
        {
            return width * height;
        }
    }
}
