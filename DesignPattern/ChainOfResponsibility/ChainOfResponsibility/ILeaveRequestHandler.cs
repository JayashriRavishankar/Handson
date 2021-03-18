using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface ILeaveRequestHandler
    {
        ILeaveRequestHandler NextHandler { get; set; }
        void HandleRequest(LeaveRequest leave );
    }
}
