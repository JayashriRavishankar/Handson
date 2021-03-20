using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverCaseStudy
{
    class SteveObserver : INotificationObserver
    {
        public string Name { get { return "Steve"; } }
        public void OnServerDown()
        {
            Console.WriteLine(Name + " has been received a notification of server is down");
        }
    }
}
