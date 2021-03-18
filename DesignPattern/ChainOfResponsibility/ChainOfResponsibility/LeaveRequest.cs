using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class LeaveRequest
    {
        public string Employee { get; set; }
        public int LeaveDays { get; set; }
    }
}
