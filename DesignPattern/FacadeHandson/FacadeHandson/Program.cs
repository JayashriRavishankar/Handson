using System;

namespace FacadeHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker facade = new ShapeMaker();
            facade.DrawCircle();
            facade.DrawRectangle();
            facade.DrawSquare();
            Console.ReadLine();
        }
    }
}
