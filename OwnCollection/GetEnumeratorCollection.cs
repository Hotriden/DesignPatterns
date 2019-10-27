using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnCollection
{
    class GetEnumeratorCollection : IEnumerable<int>
    {
        private readonly int count;

        public GetEnumeratorCollection(int count)
        {
            this.count = count;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new MyGetEnumerator(count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class MyGetEnumerator : IEnumerator<int>
    {
        private int _current;
        private int _count;

        public MyGetEnumerator(int count)
        {
            _count = count;
        }

        public int Current => _current;

        object IEnumerator.Current => _current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (_count > _current)
            {
                _current++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _current = 1;
        }
    }
}
