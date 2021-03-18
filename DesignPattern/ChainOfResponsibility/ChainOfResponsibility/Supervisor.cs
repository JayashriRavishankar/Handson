using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Supervisor:ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler
        {
            get { return nextHandler; }
            set { nextHandler = value; }
        }

        public void HandleRequest(LeaveRequest leave)
        {
            if (leave.LeaveDays >= 1 && leave.LeaveDays < 3)
            {
                Console.WriteLine("Supervisor approved leave");
            }
            else 
            {
                Console.WriteLine("Passed to ProjectManager");
                NextHandler = new ProjectManager();
                NextHandler.HandleRequest(leave);
            }
        }
    }
}
