using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            YieldCollection collect = new YieldCollection(10); // Collection using yield return
            Console.WriteLine("Yield return collection\r\n");
            foreach (var b in collect)
            {
                Console.WriteLine(b);
            }

            List<Person> list = new List<Person>() { new Person(1, "Vasya"), new Person(2, "Petya") };
            ObjectCollection objectCollection = new ObjectCollection(list);
            Console.WriteLine("ObjectCollection:\r\n");
            foreach(var b in objectCollection)
            {
                Console.WriteLine(b.Name);
            }

            GetEnumeratorCollection enumeratorCollection = new GetEnumeratorCollection(10);
            Console.WriteLine("GetEnumeratorCollection:\r\n");
            foreach(var b in enumeratorCollection)
            {
                Console.WriteLine(b);
            }
        }
    }
}
