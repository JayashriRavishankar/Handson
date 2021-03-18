using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    interface IOrderRepair
    {
        
        void ProcessPhoneRepair(string modelName);
        void ProcessAccessoryRepair(string accessoryType);
    }
}
