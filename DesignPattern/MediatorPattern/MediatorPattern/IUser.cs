using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface IUser
    {
        string Name { get; set; }
        void ReceiveMessage(IUser user,string message);
        void SendMessage(string message);
    }
}
