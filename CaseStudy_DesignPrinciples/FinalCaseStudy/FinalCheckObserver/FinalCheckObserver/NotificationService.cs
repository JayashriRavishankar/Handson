using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCheckObserver
{
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();
        private int BookTicket = 0;

        public void TicketsBooked(int tickets)
        {
            BookTicket += tickets;
            if(BookTicket >= 100)
            {
                NotifySubscriber();
            }
        }

        public void AddSubscriber(INotificationObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine(observer.Name + " is added to subscribers");
            Console.WriteLine("***  Subscribers  ***");
            foreach (var obs in observers)
            {
                Console.WriteLine(obs.Name);
            }
           
        }

        public void NotifySubscriber()
        {
            Console.WriteLine("***  Subscribers  ***");
            foreach (var obs in observers)
            {
                obs.TicketsBooked();
            }

        }

        public void RemoveSubscriber(INotificationObserver observer)
        {

            observers.Remove(observer);
            Console.WriteLine(observer.Name + " is removed from subscribers");
            Console.WriteLine("***  Subscribers  ***");
            foreach (var obs in observers)
            {
                Console.WriteLine(obs.Name);
            }
           
        }
    }
}


