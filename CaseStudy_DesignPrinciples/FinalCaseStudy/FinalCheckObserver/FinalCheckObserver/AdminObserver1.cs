using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCheckObserver
{
        class AdminObserver1 : INotificationObserver
        { 
            public string Name { get { return "Admin1"; } }

            public void TicketsBooked()
            {

                Console.WriteLine(Name + " 100 Tickets are booked");
            }
        }
    
}
