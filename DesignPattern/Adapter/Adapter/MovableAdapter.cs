using System;

namespace Adapter
{
    public interface MovableAdapter // returns speed in Kph and price in euro
    {
        double GetSpeed(); 

        double GetPrice(); 
    }
}
