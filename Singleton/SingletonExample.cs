using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonExample
    {
        private static SingletonExample singleton;

        static SingletonExample()
        {
            singleton = new SingletonExample();
        }

        private SingletonExample()
        {
        }

        public static SingletonExample GetExample
        {
            get
            {
                return singleton;
            }
        }

        public int Count { get; set; }
    }
}
