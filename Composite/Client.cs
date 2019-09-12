using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Client
    {
        public void ClientCode(Component leaf)
        {
            Console.WriteLine($"Result: {leaf.Operation()}\r\n");
        }

        public void ClientCode2(Component component, Component component2)
        {
            if (component.IsComposite())
            {
                component.Add(component2);
            }

            Console.WriteLine($"Result: {component.Operation()}\r\n");
        }
    }
}
