using System;
using static AbstractFactory.Headlight;
using static AbstractFactory.Tire;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Audi or Mercedes ");
            string car = Console.ReadLine();
            Factory factory = FactoryProducer.getFactory(car);
            ITire tire = factory.makeTire();
            tire.tire();
            IHeadlight headlight = factory.makeHeadlight();
            headlight.headlight();
            Console.ReadLine();
        }
    }
}
