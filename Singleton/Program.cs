using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonExample singleton = SingletonExample.GetExample;
            singleton.Count = 100;
            singleton.Count = 200;
            SingletonExample singletonExample = SingletonExample.GetExample;
            singletonExample.Count = 300;
            Console.WriteLine(singleton.Count);
            Console.WriteLine(singletonExample.Count);
        }
    }
}
