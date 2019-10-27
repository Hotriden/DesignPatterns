using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnCollection
{
    class ObjectCollection : IEnumerable<Person>
    {
        private readonly List<Person> _list;

        public ObjectCollection(List<Person> list) 
        {
            _list = list;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for(int i=0; i<_list.Count; i++)
            {
                yield return _list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Person
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
