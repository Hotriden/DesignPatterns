using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnCollection
{
    class YieldCollection : IEnumerable<int>
    {
        private readonly int _times;

        public YieldCollection(int time)
        {
            _times = time;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 1; i < _times; i++)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
