using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();

            MessageSubscriberTwo s2 = new MessageSubscriberTwo();

            MessageSubscriberThree s3 = new MessageSubscriberThree();

            MessagePublisher p = new MessagePublisher();

            p.Attach(s1);

            p.Attach(s2);

            p.NotifyUpdate(new Message("First Message")); //s1 and s2 will receive the update

            p.Detach(s1);

            p.Attach(s3);

            p.NotifyUpdate(new Message("Second Message")); //s2 and s3 will receive the update
            p.Attach(s1);
            p.Attach(s2);
            p.Attach(s3);

            p.ChangeState(2);

            Console.ReadLine();

        }

    }
}

