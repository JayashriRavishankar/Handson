using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwait
{
    class Program
    {
      
        public async static Task<string> Method1()
        {
            return await Method2();
        }
            
        

        public async static Task<string> Method2()
        {
            return await Task.Run(() =>
            {
            
                Thread.Sleep(5000);
                return "Hello";
            });
        }
        public static void Main(string[] args)
        {
            string result = Method1().Result;
            Console.WriteLine(result);
            Console.ReadLine();

        }

    }
}
