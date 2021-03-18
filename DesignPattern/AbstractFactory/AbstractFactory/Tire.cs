using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    //product 1
    public abstract class Tire 
    {
        public interface ITire 
        {
            void tire();
        }
        public class AudiTire : ITire 
        {
            public void tire() 
            {
                Console.WriteLine("Audi Tire");
            }
        }
        public class MercedesTire : ITire
        {
            public void tire()
            {
                Console.WriteLine("Mercedes Tire");
            }
        }
    }

}
