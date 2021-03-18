using System;
using static AbstractFactory.Headlight;
using static AbstractFactory.Tire;

namespace AbstractFactory
{
    //Concrete class or Concrete Factory
    //Varient Audi
    public class AudiFactory : Factory
    {
        public override IHeadlight makeHeadlight()
        {
            return new AudiHeadlight();
        }
        public override ITire makeTire()
        {
            return new AudiTire();
        }
    }
}
