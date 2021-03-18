using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweets director = new Sweets();

            Builder b1 = new ConcreteChild();
            Builder b2 = new ConcreteAdult();
            Console.WriteLine("\nSweet Shop");
            // Construct two products
            director.Construct(b1);
            Console.WriteLine("\nChild Package");
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Console.WriteLine("\nAdult Package");
            Product p2 = b2.GetResult();
            p2.Show();

            // Wait for user

            Console.ReadKey();
        }
    }
}
