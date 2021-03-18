using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(IUser user,string message);
    }
}
