using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class MessageSubscriberOne : IObserver

    {

        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());

        }

    }

    public class MessageSubscriberTwo : IObserver

    {
        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());

        }

    }

    public class MessageSubscriberThree : IObserver

    {
        public void Update(Message m)
        {

            Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());

        }

    }
}
