using System;

namespace AbstractFactoryCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new ConcreteCarFactory();
            CarClient carClient = new CarClient(carFactory);
            carClient.BuildMicroCar(Location.USA);

            carClient.BuildMiniCar(Location.INDIA);

            carClient.BuildLuxuryCar(Location.DEFAULT);

            Console.ReadKey();
        }
    }
}
