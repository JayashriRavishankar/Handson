using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryCaseStudy
{
    class CarClient
    {
        CarFactory carFac;
        public CarClient(CarFactory carFactory)
        {
            carFac = carFactory;
        }
        public void BuildMicroCar(Location location)
        {
            carFac.MakeMicroCar(location, CarType.MICRO);
        }
        public void BuildMiniCar(Location location)
        {
            carFac.MakeMiniCar(location, CarType.MINI);
        }
        public void BuildLuxuryCar(Location location)
        {
            carFac.MakeLuxuryCar(location, CarType.LUXURY);
        }
    }
}
