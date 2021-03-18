using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeHandson
{
    public interface Shape
    {
        void Draw();

    }

    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }
}
