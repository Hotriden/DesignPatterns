using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeClass prototype = new ConcretePrototype("X-One");
            PrototypeClass clonedPrototype = prototype.Clone();
        }
    }
}
