using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCheckObserver
{
    public interface INotificationObserver
    {
        string Name { get; }
        void TicketsBooked();
    }
}
