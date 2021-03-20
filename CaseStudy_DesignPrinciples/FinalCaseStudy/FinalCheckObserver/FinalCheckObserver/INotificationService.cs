using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCheckObserver
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifySubscriber();
    }
}
