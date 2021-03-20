using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverCaseStudy
{
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> observer1 = new List<INotificationObserver>();
        public void AddSubscriber(INotificationObserver observer)
        {
            observer1.Add(observer);
            Console.WriteLine(observer.Name + " is added to subscribers");
            Console.WriteLine("---Subscribers---");

            foreach (var obs in observer1)
            {
                Console.WriteLine(obs.Name);
            }

        }
        public void RemoveSubscriber(INotificationObserver observer)
        {
            observer1.Remove(observer);
            Console.WriteLine(observer.Name + " is removed from subscription");

            Console.WriteLine("---Subscribers---");
            foreach (var obs in observer1)
            {
                Console.WriteLine(obs.Name);
            }
        }
        public void NotifySubscriber()
        {
            Console.WriteLine("Server Down");

            foreach (var obs in observer1)
            {
                obs.OnServerDown();
            }
        }
    }
}
