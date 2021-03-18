using static AbstractFactory.Headlight;
using static AbstractFactory.Tire;

namespace AbstractFactory
{
    //AbstractFactory for different categories 
    public abstract class Factory
    {
        public abstract IHeadlight makeHeadlight();
        public abstract ITire makeTire();
    }
}
