using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            BaseOperation1();
            RequiredOperation1();
            Hook1();
            BaseOperation2();
            Hook2();
            RequiredOperation2();
        }

        protected void BaseOperation1()
        {
            Console.WriteLine("Base Operation 2 done");
        }

        protected void BaseOperation2()
        {
            Console.WriteLine("Base Operation 2 done");
        }

        protected abstract void RequiredOperation1();
        protected abstract void RequiredOperation2();

        protected virtual void Hook1() { }
        protected virtual void Hook2() { }
    }
}
