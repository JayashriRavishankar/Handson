using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class ChatMediator : IChatMediator
    {
        public List<IUser> users = new List<IUser>();
        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(IUser user, string message)
        {
            foreach (var u in users) 
            {
                if (u!=user) 
                {
                    u.ReceiveMessage(user, message);
                }
            }
        }
    }
}
