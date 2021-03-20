using System;

namespace FinalCheckObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            AdminObserver1 admin1 = new AdminObserver1();
            AdminObserver2 admin2 = new AdminObserver2();

            NotificationService service = new NotificationService();
            service.AddSubscriber(admin1);
            service.AddSubscriber(admin2);
            service.TicketsBooked(90);

            service.RemoveSubscriber(admin2);
            service.TicketsBooked(100);

            Console.ReadLine();
        }
    }
}
