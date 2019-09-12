using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class ConcreteClass : AbstractClass
    {
        protected override void RequiredOperation1()
        {
            Console.WriteLine("Required Operation 1 done");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("Required Operation 2 done");
        }

        protected override void Hook1()
        {
            Console.WriteLine("Hook 1 done");
        }
    }
}
