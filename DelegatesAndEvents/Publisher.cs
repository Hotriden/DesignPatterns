using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DelegatesAndEvents
{
    class Publisher
    {
        public delegate void ShowMessage(string message);

        public void Moving(string name, int count)
        {
            for(int i=0;i<count; i++)
            {
                Show(String.Format($"{name} has arived {i} kilomiters"));
                Thread.Sleep(1000);
            }
        }

        public event ShowMessage Show;
    }
}
