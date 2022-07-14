using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatronFactory
{
    public abstract class Creator
    {
        public void someOperation()
        {
            IProduct product = CreateProduct();
            product.doStuf();
        }

        public abstract IProduct CreateProduct();

        
    }
}
