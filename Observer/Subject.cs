using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver obs)
        {
            Console.WriteLine("Subject: Attached an observer");
            observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            observers.Remove(obs);
            Console.WriteLine("Subject: Detached an observer");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach(IObserver b in observers)
            {
                b.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nSubject: I'm doing something important");
            this.State = new Random().Next(0, 10);

            Thread.Sleep(1500);

            Console.WriteLine("Subject: My state has just changed to " + this.State);
            this.Notify();
        }
    }
}
