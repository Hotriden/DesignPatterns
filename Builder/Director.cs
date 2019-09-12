using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // Директор может строить несколько вариаций продукта, используя
        // одинаковые шаги построения.
        public void buildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }

        public void buildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
