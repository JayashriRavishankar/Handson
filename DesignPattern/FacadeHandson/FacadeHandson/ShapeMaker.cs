using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeHandson
{
    public class ShapeMaker
    {
        private Circle circle = new Circle();
        private Rectangle rectangle = new Rectangle();
        private Square square = new Square();

        public void DrawCircle()
        {
            Console.WriteLine("******** Creating a Shape **********\n");
            circle.Draw();
            Console.WriteLine("\n******** Circle creation complete **********");
        }
        public void DrawRectangle()
        {
            Console.WriteLine("******** Creating a Shape **********\n");
            rectangle.Draw();
            Console.WriteLine("\n******** Rectangle creation complete **********");
        }
        public void DrawSquare()
        {
            Console.WriteLine("******** Creating a Shape **********\n");
            square.Draw();
            Console.WriteLine("\n******** Square creation complete **********");
        }
    }
}
