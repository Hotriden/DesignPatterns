using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public abstract class PrototypeClass
    {
        public string Id { get; set; }
        public PrototypeClass(string id)
        {
            Id = id;
            Console.WriteLine("Based constructor called");
        }

        public virtual PrototypeClass Clone()
        {
            return (PrototypeClass)this.MemberwiseClone();
        }
    }
}
