using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; }
        void OnServerDown();
    }
}
