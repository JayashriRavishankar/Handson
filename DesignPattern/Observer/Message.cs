using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Message
    {
         String messageContent;
        public Message(String m)
        {
            this.messageContent = m;
        }
        public String getMessageContent()
        {
            return messageContent;
        }
    }
}
