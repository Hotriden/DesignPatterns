using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new ConcreteCreator();
            Product product = creator.FactoryMethod();
            Console.WriteLine(product.Get_Type());
        }
    }
}
