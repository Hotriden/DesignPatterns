using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubsystemB
    {
        internal string OperationOne()
        {
            return "This operation 1 form system B\r\n";
        }

        internal string OperationTwo()
        {
            return "This operation 2 form system B\r\n";
        }
    }
}
