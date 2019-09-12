using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if((subject as Subject).State > 5)
            {
                Console.WriteLine("ConcreteSubjectB: Reacted to the event");
            }
        }
    }
}
