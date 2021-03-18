using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest leave = new LeaveRequest()
            {
                LeaveDays = 3,
                Employee = "Jayashri"
            };
            ILeaveRequestHandler _leave = new Supervisor();
            _leave.HandleRequest(leave);

            Console.ReadLine();
        }
    }
}
