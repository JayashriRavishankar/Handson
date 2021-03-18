using System;

namespace Adapter
{
    public interface Movable // returns speed in MPH and price in Usd
    {
        double GetSpeed(); 

        double GetPrice(); 
    }
}
