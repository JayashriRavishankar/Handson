using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FactoryProducer
    {
        public static Factory getFactory(string carname)
        {
            if (carname == "Mercedes")
            {
                return new MercedesFactory();
            }
            else if (carname == "Audi")
            {
                return new AudiFactory();
            }
            else
            {
                return null;
            }
        }
    }
}

