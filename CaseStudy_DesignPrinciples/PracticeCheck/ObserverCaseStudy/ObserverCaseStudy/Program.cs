using System;

namespace ObserverCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            SteveObserver steveObserver = new SteveObserver();
            JohnObserver johnObserver = new JohnObserver();
            NotificationService service = new NotificationService();
            service.AddSubscriber(johnObserver);
            service.AddSubscriber(steveObserver);
            service.NotifySubscriber();
            service.RemoveSubscriber(johnObserver);
            Console.ReadLine();
        }
    }
}
