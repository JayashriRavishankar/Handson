using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverCaseStudy
{
   class JohnObserver : INotificationObserver
   {
        public string Name { get { return "John"; } }
        public void OnServerDown()
        {
            Console.WriteLine(Name + " has been received a notification of server is down"); 
        }
   }
}
