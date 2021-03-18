using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
   public class DbConn
    {
        private static DbConn instance;
        private DbConn()
        {
            Console.WriteLine("Singleton Instance");
        }
        public static DbConn getInstance()
        {
            if (instance == null)
            {
                instance = new DbConn();

            }
            return DbConn.instance;
        }
        public void PrintDetails(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }

}
