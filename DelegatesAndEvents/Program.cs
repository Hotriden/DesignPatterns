using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.Show += Publisher_Show;
            publisher.Moving("Carl", 10);
        }

        private static void Publisher_Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
