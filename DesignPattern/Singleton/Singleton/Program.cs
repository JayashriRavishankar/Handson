using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConn instance = DbConn.getInstance();
            DbConn instance1 = DbConn.getInstance();
            instance.PrintDetails("Jay");
            instance1.PrintDetails("Shri");
            Console.WriteLine(instance.GetHashCode());
            Console.WriteLine(instance1.GetHashCode());
            Console.ReadLine();
        }
    }
}
