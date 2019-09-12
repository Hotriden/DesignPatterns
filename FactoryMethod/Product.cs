using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class Product
    {
        public abstract string Get_Type();
    }

    class ConcreteProduct : Product
    {
        public override string Get_Type()
        {
            return "It's Concrete Product";
        }
    }
}
