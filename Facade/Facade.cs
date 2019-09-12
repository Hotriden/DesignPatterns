using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        private readonly SubsystemA _subsystemA;
        private readonly SubsystemB _subsystemB;

        public Facade(SubsystemA sys1, SubsystemB sys2)
        {
            _subsystemA = sys1;
            _subsystemB = sys2;
        }

        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystemA.OperationOne();
            result += this._subsystemB.OperationOne();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystemA.OperationTwo();
            result += this._subsystemB.OperationTwo();
            return result;
        }
    }
}
