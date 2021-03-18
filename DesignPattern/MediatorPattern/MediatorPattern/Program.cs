using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ChatMediator chat = new ChatMediator();
                IUser user1 = new PremiumUser() { Name = "FirstPerson" };
                IUser user2 = new BasicUser() { Name = "SecondPerson" };
                IUser user3 = new BasicUser() { Name = "ThirdsPerson" };

                chat.AddUser(user1);
                chat.AddUser(user2);
                chat.AddUser(user3);



                chat.SendMessage(user1, "Welcome");
               
                Console.ReadLine();
            }
        }
    }
}
