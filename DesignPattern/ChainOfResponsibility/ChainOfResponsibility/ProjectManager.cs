using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ProjectManager:ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;

        public ILeaveRequestHandler NextHandler
        {
            get { return nextHandler; }
            set { nextHandler = value; }
        }

        public void HandleRequest(LeaveRequest leave)
        {
            if (leave.LeaveDays >3 && leave.LeaveDays <=5)
            {
                Console.WriteLine("ProjectManager approved leave");
            }
            else
            {
                Console.WriteLine("Passed to HR");
                NextHandler = new HR();
                NextHandler.HandleRequest(leave);
            }
        }
    }
}
