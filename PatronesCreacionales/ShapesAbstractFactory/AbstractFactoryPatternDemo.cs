using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesAbstractFactory
{
    /// <summary>
    /// This is the client class
    /// </summary>
   public class AbstractFactoryPatternDemo
    {
        /// <summary>
        /// Method that uses diferent abstract factory implementations
        /// </summary>
       public void Main() 
        {
            Console.WriteLine("GENERATING NORMAL SHAPES....");
            IAbstractFactory factory = new ShapeFactory();

            IShape shape = factory.GetRectangle();
            Rectangle rectangle = (Rectangle) shape;
            rectangle.width = 100;
            rectangle.height = 50;
            Draw(rectangle);

            shape = factory.GetSquare();
            Square square = (Square) shape;
            square.width = 60;
            square.height = 15;
            Draw(square);

            ///---------------------------------
            Console.WriteLine();
            Console.WriteLine("GENERATING ROUNDED SHAPES....");
            factory = new RoundedShapeFactory();

            shape = factory.GetRectangle();
            RoundedRectangle roundedRectangle = (RoundedRectangle)shape;
            roundedRectangle.width = 100;
            roundedRectangle.height = 50;
            Draw(roundedRectangle);

            shape = factory.GetSquare();
            RoundedSquare roundedSquare = (RoundedSquare)shape;
            roundedSquare.width = 60;
            roundedSquare.height = 15;
            Draw(roundedSquare);

            ///---------------------------------

            Console.ReadLine();
        }

        /// <summary>
        /// Some client logic that uses IShape interface methods
        /// </summary>
        /// <param name="shape"></param>
        private void Draw(IShape shape) 
        {

            shape.Draw();
        }
    }
}
